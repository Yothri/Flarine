
# Flarine

[![discord](https://discordapp.com/api/guilds/413727727078604822/widget.png)](https://discord.gg/vhRt583)

Flarine is an experimental FlyFF Legacy Server Emulator.

# Preamble
This is my first Emulator project and if I would code an emulator again I would change several things, so I cannot proudly present my best work here as this is probably really crappy in other peoples eyes.

# Requirements
Flarine targets the following Frameworks:
* All Libraries are targeting **NetStandard2.0**
* All Executables (which rely on the libraries) are targeting **.NET Core 2.0** and **.NET Framework 4.6.1**
* Also the following libraries are being used:
    * [Ether.Network](https://github.com/Eastrall/Ether.Network)
    * [Newtonsoft.Json](https://www.newtonsoft.com/json)
    * [EntityFrameworkCore 2.0](https://docs.microsoft.com/en-us/ef/core/what-is-new/)
    * [Microsoft.Extensions.Logging](https://www.nuget.org/packages/Microsoft.Extensions.Logging/)
    * Probably more but I dont remember right now.

# How to use
Flarine is currently not in an user-friendly state to setup. However if you really want to try it out then have a look at the [Getting Started](https://github.com/Yothri/Flarine/wiki/Getting-Started) Wiki-Page.

# Status
* GateServer - 100%
* LoginServer - 80%
   * Account Creation - Done
   * Character Creation - Almost done, more character properties need to be added to database and templates on different classes.
   * Character Deletion - Done
   * ISC Communication - Done
* GameServer - Like probably not even 0.1%
   * Login Hero to World - Partially done, need to transfer all game data and character data. For now only required are sent.
   * Hero Join - Partially done, same like above.
   * Hero Disconnect - Done, but probably rethink structuring of this.
   * Hero Movement - Done, but very crappy probably.
   * ISC Communication - Done

![Ingame Image](https://puu.sh/zaiuO/718f01e7f4.jpg)

