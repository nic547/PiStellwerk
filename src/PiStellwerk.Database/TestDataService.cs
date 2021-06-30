﻿// <copyright file="TestDataService.cs" company="Dominic Ritz">
// Copyright (c) Dominic Ritz. All rights reserved.
// Licensed under the GNU GPL license. See LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;
using PiStellwerk.Database.Model;

namespace PiStellwerk.Database
{
    /// <summary>
    /// Provides data for testing.
    /// </summary>
    public static class TestDataService
    {
        /// <summary>
        /// Test function generating example data.
        /// Just random items I think of, no need for a burglary :P .
        /// </summary>
        /// <returns>List of <see cref="Engine"/>.</returns>
        public static IReadOnlyList<Engine> GetEngines()
        {
            return new List<Engine>()
            {
                new Engine()
                {
                    Name = "Roco BR 193 493 (Hupac Vollblau)",
                    SpeedSteps = 128,
                    Address = 49,
                    TopSpeed = 200,
                    Functions =
                    {
                        new DccFunction(0, "Headlights"),
                        new DccFunction(1, "Sound"),
                        new DccFunction(2, "Horn high - long"),
                        new DccFunction(3, "Horn low - long"),
                        new DccFunction(4, "Compressor"),
                        new DccFunction(5, "Couple/decouple Sound"),
                        new DccFunction(6, "Shunting Gear + Shungting Light"),
                        new DccFunction(7, "High Beams"),
                        new DccFunction(8, "Horn high - short"),
                        new DccFunction(9, "Horn low - short"),
                        new DccFunction(10, "Cab lighting (at standstill)"),
                        new DccFunction(11, "Curve squeaking"),
                        new DccFunction(12, "Conductor Whistle"),
                        new DccFunction(13, "Passing train"),
                        new DccFunction(14, "Mute"),
                        new DccFunction(15, "Headlights + Single White"),
                        new DccFunction(16, "Headlights + Double Reds"),
                        new DccFunction(17, "Headlights + Single Red"),
                        new DccFunction(18, "Double Reds"),
                        new DccFunction(19, "Single Red"),
                        new DccFunction(20, "None (Light)"),
                        new DccFunction(21, "Sequence \"Zwangsbremsung\""),
                        new DccFunction(22, "Doors"),
                        new DccFunction(23, "Störung Störung Störung"),
                        new DccFunction(24, "Zugbeeinflussung 3x"),
                        new DccFunction(25, "SIFA"),
                        new DccFunction(26, "Brake squeal"),
                        new DccFunction(27, "Decrease volume"),
                        new DccFunction(28, "Inrcease volume"),
                    },
                    Tags =
                    {
                        "Vectron",
                        "Siemens",
                        "dri",
                        "freight",
                    },
                },

                new Engine()
                {
                    Name = "Roco BR 193 492 (Hupac Nightpiercer)",
                    SpeedSteps = 128,
                    Address = 49,
                    TopSpeed = 200,
                    Functions =
                    {
                        new DccFunction(0, "Headlights"),
                        new DccFunction(1, "Sound"),
                        new DccFunction(2, "Horn high - long"),
                        new DccFunction(3, "Horn low - long"),
                        new DccFunction(4, "Compressor"),
                        new DccFunction(5, "Couple/decouple Sound"),
                        new DccFunction(6, "Shunting Gear + Shungting Light"),
                        new DccFunction(7, "High Beams"),
                        new DccFunction(8, "Horn high - short"),
                        new DccFunction(9, "Horn low - short"),
                        new DccFunction(10, "Cab lighting (at standstill)"),
                        new DccFunction(11, "Curve squeaking"),
                        new DccFunction(12, "Conductor Whistle"),
                        new DccFunction(13, "Passing train"),
                        new DccFunction(14, "Mute"),
                        new DccFunction(15, "Headlights + Single White"),
                        new DccFunction(16, "Headlights + Double Reds"),
                        new DccFunction(17, "Headlights + Single Red"),
                        new DccFunction(18, "Double Reds"),
                        new DccFunction(19, "Single Red"),
                        new DccFunction(20, "None (Light)"),
                        new DccFunction(21, "Sequence \"Zwangsbremsung\""),
                        new DccFunction(22, "Doors"),
                        new DccFunction(23, "Störung Störung Störung"),
                        new DccFunction(24, "Zugbeeinflussung 3x"),
                        new DccFunction(25, "SIFA"),
                        new DccFunction(26, "Brake squeal"),
                        new DccFunction(27, "Decrease volume"),
                        new DccFunction(28, "Inrcease volume"),
                    },
                    Tags =
                    {
                        "79117",
                        "Vectron",
                        "Siemens",
                        "dri",
                        "Sound",
                        "Electric",
                        "Freight",
                        "Multisystem",
                    },
                },

                new Engine()
                {
                    Name = "Roco BR 193 Gotthardo (SBB C Int)",
                    Tags =
                    {
                        "SBB Cargo",
                        "Vectron",
                        "Siemens",
                        "dri",
                        "Electric",
                        "Multisystem",
                        "freight",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                    Functions =
                    {
                        new DccFunction(0, "Headlights"),
                        new DccFunction(1, "Sound"),
                        new DccFunction(2, "Horn high - long"),
                        new DccFunction(3, "Horn low - long"),
                        new DccFunction(4, "Compressor"),
                        new DccFunction(5, "Couple/decouple Sound"),
                        new DccFunction(6, "Shunting Gear + Shunting Light"),
                        new DccFunction(7, "High Beams"),
                        new DccFunction(8, "Horn high - short"),
                        new DccFunction(9, "Horn low - short"),
                        new DccFunction(10, "Cab lighting (at standstill)"),
                        new DccFunction(11, "Curve squeaking"),
                        new DccFunction(12, "Conductor Whistle"),
                        new DccFunction(13, "Passing train"),
                        new DccFunction(14, "Mute"),
                        new DccFunction(15, "Headlights + Single White"),
                        new DccFunction(16, "Headlights + Double Reds"),
                        new DccFunction(17, "Headlights + Single Red"),
                        new DccFunction(18, "Double Reds"),
                        new DccFunction(19, "Single Red"),
                        new DccFunction(20, "None (Light)"),
                        new DccFunction(21, "Sequence \"Zwangsbremsung\""),
                        new DccFunction(22, "Doors"),
                        new DccFunction(23, "Störung Störung Störung"),
                        new DccFunction(24, "Zugbeeinflussung 3x"),
                        new DccFunction(25, "SIFA"),
                        new DccFunction(26, "Brake squeal"),
                        new DccFunction(27, "Decrease volume"),
                        new DccFunction(28, "Increase volume"),
                    },
                },

                new Engine()
                {
                    Name = "Märklin Re 474 003",
                    Tags =
                    {
                        "Siemens",
                        "ES 64 F4",
                        "SBB Cargo",
                        "dri",
                        "Electric",
                        "Multisystem",
                        "Freight",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                    Functions =
                    {
                        new DccFunction(0, "Headlights / Red marker light"),
                        new DccFunction(1, "HIgh beams"),
                        new DccFunction(2, "Operating Sounds"),
                        new DccFunction(3, "High pitched horn"),
                        new DccFunction(4, "ABV (off)"),
                        new DccFunction(5, "Brake squealing (off)"),
                        new DccFunction(6, "Headlights Engineer‘s Cab 2 off"),
                        new DccFunction(7, "Low pitched horn"),
                        new DccFunction(8, "Headlights Engineer‘s Cab 1 off"),
                        new DccFunction(9, "Compressor"),
                        new DccFunction(10, "Compressed air"),
                        new DccFunction(11, "Station announcement"),
                        new DccFunction(12, "Conductor whistle"),
                        new DccFunction(13, "Sanding"),
                        new DccFunction(14, "Coupling / uncoupling"),
                        new DccFunction(15, "Squealing brakes"),
                    },
                },
                new Engine()
                {
                    Name = "Märklin Re 460 Circus Knie",
                    Tags =
                    {
                        "SLM",
                        "dri",
                        "Electric",
                        "Passenger",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                    Functions =
                    {
                        new DccFunction(0, "Headlights with „Swiss headlight changeover“"),
                        new DccFunction(1, "Switching marker lights(1 x white -> 1 x red)"),
                        new DccFunction(2, "Operating sounds"),
                        new DccFunction(3, "Sound effect: Horn"),
                        new DccFunction(4, "Long distance headlights"),
                        new DccFunction(5, "Engineer‘s cab lighting"),
                        new DccFunction(6, "Headlights Engineer‘s Cab 2 off"),
                        new DccFunction(7, "Sound effect: Short horn blast "),
                        new DccFunction(8, "Headlights Engineer‘s Cab 1 off"),
                        new DccFunction(9, "Sound effect: Squealing brakes off"),
                        new DccFunction(10, "ABV, off"),
                        new DccFunction(11, "Sound effect: Blower"),
                        new DccFunction(12, "Sound effect: Conductor whistle"),
                        new DccFunction(13, "Sound effect: Compressor"),
                        new DccFunction(14, "Sound effect: Letting off air"),
                        new DccFunction(15, "Sound effect: Squealing brakes on"),
                        new DccFunction(16, "Marker lights (2 x red)"),
                        new DccFunction(17, "Sound effect: Sanding"),
                        new DccFunction(18, "Low speed switching range + switching lights"),
                        new DccFunction(19, "Train announcement 1"),
                        new DccFunction(20, "Warning signal (red)"),
                        new DccFunction(21, "Sound effect: Doors being closed"),
                        new DccFunction(22, "Wrong track running in Switzerland(1 x red, 2 x white)"),
                        new DccFunction(23, "Station announcements 1"),
                        new DccFunction(24, "Station announcements 2"),
                        new DccFunction(25, "Station announcements 3"),
                        new DccFunction(26, "Station announcements 1"),
                        new DccFunction(27, "Train announcements 2"),
                        new DccFunction(28, "Train announcements 3"),
                    },
                },
                new Engine
                {
                    Name = "Märklin Re 620 X-Rail",
                    Tags =
                    {
                        "SLM",
                        "Re 620 088-5",
                        "Re 6/6 Linthal",
                        "SBB Cargo",
                        "37326",
                        "Electric",
                        "Universal",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },

                new Engine
                {
                    Name = "Märklin Re 620 058",
                    Tags =
                    {
                        "SLM",
                        "Re 6/6 11658",
                        "SBB Cargo",
                        "37321",
                        "Electric",
                        "Auvernier",
                        "Universal",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },
                new Engine
                {
                    Name = "Märklin Re 6/6 Balerna",
                    Tags =
                    {
                        "11672",
                        "SLM",
                        "SBB",
                        "dri",
                        "37325",
                        "Electric",
                        "Universal",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },
                new Engine
                {
                    Name = "Märklin Re 420 Circus Knie",
                    Tags =
                    {
                        "26615",
                        "SLM",
                        "SBB Personenverkehr",
                        "Re 420 294",
                        "Re 4/4 II 11294",
                        "dri",
                        "Electric",
                        "Universal",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },
                new Engine
                {
                    Name = "Märklin Re 482 036 (SBB Cargo)",
                    Tags =
                    {
                        "37446",
                        "Bombardier",
                        "dri",
                        "Electric",
                        "Freight",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },
                new Engine
                {
                    Name = "ES 64 F4 - 063 (MRCE)",
                    Tags =
                    {
                        "Märklin 39863",
                        "Siemens",
                        "dri",
                        "BR 189",
                        "Eurosprinter",
                        "Electric",
                        "Multisystem",
                        "Freight",
                        "Sound",
                        "SBB Cargo International",
                        "Mitsui Rail Capital Europe",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },

                new Engine
                {
                    Name = "Black Pearl",
                    Tags =
                    {
                        "Roco 79277",
                        "SLM",
                        "dri",
                        "Re 465 016",
                        "Electric",
                        "Freight",
                        "Sound",
                        "BLS Cargo",
                        "Railcare",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "Cat's Eye",
                    Tags =
                    {
                        "Roco 79643 ",
                        "SLM",
                        "dri",
                        "Re 465 015",
                        "Electric",
                        "Freight",
                        "Sound",
                        "BLS Cargo",
                        "Railcare",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "Re 475 BLS Alpinist",
                    Tags =
                    {
                        "Roco 79920",
                        "Siemens",
                        "dri",
                        "91 85 4475 402-4 CH-BLS",
                        "Electric",
                        "Multisystem",
                        "Freight",
                        "Sound",
                        "BLS Cargo",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "BR 193 \"Das ist Grün\"",
                    Tags =
                    {
                        "Roco 79103",
                        "91 80 6193 301-9 D-DB",
                        "Siemens",
                        "dri",
                        "Electric",
                        "Multisystem",
                        "Freight",
                        "Sound",
                        "DB Cargo",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "BR 193 (Railpool)",
                    Tags =
                    {
                        "Roco 79916",
                        "91 80 6193 802-6 D-Rpool",
                        "Siemens",
                        "dri",
                        "Electric",
                        "Multisystem",
                        "Freight",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "BR 193 (MRCE)",
                    Tags =
                    {
                        "Roco 79926",
                        "91 80 6193 873-7 D-DISPO",
                        "X4 E - 873",
                        "Siemens",
                        "dri",
                        "Electric",
                        "Dualsystem",
                        "Freight",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "BR 193 (DB Cargo)",
                    Tags =
                    {
                        "Roco 79926",
                        "91 80 6193 307-6 D-DB",
                        "Siemens",
                        "dri",
                        "Electric",
                        "Dualsystem",
                        "Freight",
                        "Sound",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },

                new Engine
                {
                    Name = "BLS Re 4/4 185",
                    Tags =
                    {
                        "Roco 79781",
                        "Lalden",
                        "SLM",
                        "dri",
                        "Electric",
                        "Freight",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },

                new Engine
                {
                    Name = "BLS Re 4/4 174",
                    Tags =
                    {
                        "Roco 79819",
                        "Frutigen",
                        "SLM",
                        "dri",
                        "Electric",
                        "Freight",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },

                new Engine
                {
                    Name = "BLS Re 4/4 194",
                    Tags =
                    {
                        "Roco 79783",
                        "Thun",
                        "SLM",
                        "dri",
                        "Electric",
                        "Freight",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 140,
                },

                new Engine
                {
                    Name = "SBB Re 460 \"Munot\"",
                    Tags =
                    {
                        "Märklin 39461",
                        "91 85 4 460 ",
                        "SLM",
                        "dri",
                        "Electric",
                        "Passenger",
                    },
                    SpeedSteps = 128,
                    TopSpeed = 200,
                },
            };
        }
    }
}
