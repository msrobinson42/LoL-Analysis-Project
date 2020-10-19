# LoL-Analysis-Project

Still in development

Started in fall 2019, goal was to consume Riot Game's API for their game League Of Legends and draw conclusions based on the primitive data types received by the end points.

## ClientsLib 

A class library dedicated to receiving and deserializing the json into their appropriate models using the Newtonsoft external library and asynchronous methods. Find that each client converts the json first into a DTO, and then from DTO into it's corresponding model.

The UriFactory includes low level string manipulation to handle the segments and query parameters of any particular endpoint.

Riot Games offers endpoints that are specific to stats per game (player kills/deaths, positional data, item purchases, etc).
DataDragon is an open source endpoint that includes static data for the game (champion stats, monster stats, ability damage values, mana costs, etc). DataDragonClient always returns most up to date data from this endpoint.

## ContractsLib

A class library dedicated to holding information regarding both the DTO and model information for the domain. Each DTO class holds it's corresponding extension method class, which converts from DTO to model. This is called from the ClientLib project.

I still need to convert the properties of the Model classes to readonly, to prevent unintentional mutation. 

Here is a domain summary of each type of model:
* League Entry - holds information that could be found in a user's profile:
  * Summoner Name
  * Rank
  * Tier
  * Total Win/Loss
* Match List - Holds information that could be found in a user's match history:
  * What lane or role they played in a specific game
  * What particular champion they played
  * Which game mode they decided to play in
* Match - Holds information for any single game:
  * Bans
  * Participants
  * Timeline information
  * Stats information
  * Team information
* Summoner - Holds information regarding the individual player (called summoner):
  * Name
  * Id information
  * Level
* Timeline- Holds information about what happens at a specific timestamp in a given game:
  * Item purchased
  * Deaths/Kills
  * Those who participated in said kill/death (by ID)
  * Positional data per timestamp
  * Structure destruction
  * Neutral objective accomplishment
  * Build identifier (which skills were leveled up in what order)
  
Need to develop more analysis tools to calculate/determine conclusions.

## ViewModelsLib

Largely in development. Used to display information in an appropriate way to the console rather than calling the information directly from the ModelLib, which I understand is poor practice. Will be filled in as I create more Models that determine conclusions from given data.

## ConsoleView

Composition root.

Set up URI and personal api key to access the endpoints.

Create httpclient and set to accept json.

Get user input to request data by summoner name (player name).

Generate full URI and asynchronously call endpoints for all data. Only await data needed to go to next step.

Perform same API call on static DataDragon endpoint. This could likely be easily called and maintained in a database using Entity Framework.

Populates a quick view model test of some information based on number of matches requested by user input.

## Finally

Still some work to go. Clients are working appropriately, and I'm happy with them at my current knowledge. I have a distinct lack of knowledge about asynchronous programming, so I am sure there are improvements to be made within the architecture of making the endpoint calls. 

I need to implement more calculation-based models, so I can build up algorithms that return intelligent/conditional information based the input, rather than just displaying the given properties. 

Once I have a minimally viable product in terms of models, I need to create a more sophisticated view. I would probably want to create my own web API to call, so that I could access the information from a website, mobile app, or desktop app. I know that this is possible, and preferred practice, but I feel I need to gain a bit more knowledge before I could implement something like that in a professional or competent manner.

**Zach Robinson**
