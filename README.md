
# Flarine
Flarine is an experimental FlyFF Legacy Server Emulator.

# Status
Early development phase. Since a hundful of commits the game client is able to get ingame, but thats it. Not playable at all.

# Projects
There are currently 10 projects in this solution:
* ClientCommon - A collection of some useful Model-Classes and Utilization ripped from Original Game Client.
* WebCommon - A collection of most WPDs (Web Packet Data) and their serializiation ripped from Original Game Client.
* Flarine.Gate - The **Gate Server** telling the game client the **Auth Server** to connect to.
* Flarine.Login - The **Login Server** the game client authenticates with.
* Flarine.Core - A collection of some Base Classes the whole project requires.
* Flarine.Database - Provides the use of different databases using Microsoft Entity Framework Core 2.0.
    * Currently supports SQLite. Support for MySQL and probably other engines will come later.
* Flarine.Network - Provides communication between Game Server and Game Client (Web Packet Data (REST) & TCP)
* Flarine.Tools - A project for future tools. Probably gets replaced with an UI based project later.
* Flarine.Game - The **Game Server** which is the main part of this whole project.
* Ether.Network - The Networking Library this project uses for TCP/IP communications.

# Progress
The project consists of 3 important parts:
* Gate Server
    * Done
        * Provide Game Client with Auth Server Url. (100%)
    * Todo
        * Maybe some error handling, but actually most of the stuff is done here. This Server's Task is just that one thing.
* Login Server
    * Done
        * TrackingLocations -> Did not yet figured out what those are, but the game does not really need them afaik. At least, game does not crash when sending an empty TrackingLocations Array.
        * SystemSettings -> Currently trying to figure out which of those Settings the game necessarily needs, but the implementation is done and game continues to next part.
        * SupportedLanguages -> This just tells the game client which languages exist on the server. Languages are placed in `ClientTexts` folder in `JSON` format. Loading the language files is already implemented but might need some fine tuning.
        * IpCheck -> This is just returning true or false to Game Client, needs investigation but it´s implemented.
        * ClientTextMetaDatas -> This provides the Game Client with the language file. Implemented and works fine.
        * GameServers -> Provides the client with all available game servers.
        * CreateGuestUser -> Creates a guest user for the client. (Account creation basically)
        * Login -> Authenticate the game client.
        * GameAssetBundles -> Provides the game client with game asset information (File Patching info).
        * Notices -> Probably just notices to the game client, empty array for now, works.
    * Todo
        * Testing, maybe possibilty for Google and Facebook Login, but not sure if that will work.
    * Status
        * The Login Server is almost finished, it needs some testing and there are some features that may be added in future but they are not necessary to play the game.
* Game Server
    * Done
        * GameServerRegistration at Login Server (ISC).
        * LoginHandler -> Associate the PhotonConnection with the WPDConnection using the GameAccessToken.
        * HeroLogin -> Put hero with default data to the world.
    * Todo
        * Everything lol. Nothing really works as of now.
        
![Ingame Image](https://puu.sh/z8BmD/4af270fad9.png)
