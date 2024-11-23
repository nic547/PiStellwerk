// This file is part of the TauStellwerk project.
//  Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TauStellwerk.Data.ImageService;
using TauStellwerk.Server.Services.TransferService;

namespace TauStellwerk.Server.Controllers;

[ApiController]
public class BackupUploadController : ControllerBase
{
    private readonly TauStellwerkOptions _options;
    private readonly ITransferService _transferService;
    private readonly ImageService _imageService;

    public BackupUploadController(IOptions<TauStellwerkOptions> options, ITransferService transferService, ImageService imageService)
    {
        _options = options.Value;
        _transferService = transferService;
        _imageService = imageService;
    }

    [HttpPost]
    [Route("/upload/backup")]
    public Task UploadBackup(IFormFile file)
    {
        var filename = _options.DataTransferDirectory + "/import.zip";
        using var localFile = System.IO.File.Create(filename);
        file.CopyTo(localFile);
        localFile.Close();

        _ = Task.Run(async () =>
        {
            await _transferService.ImportEverything(filename);
            System.IO.File.Delete(filename);
            await _imageService.CreateDownScaledImages();
        });

        return Task.CompletedTask;
    }
}
