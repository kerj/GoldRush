# _Gold Rush_

#### _This program will create a grid shaped game made out of buttons.  You will have a certain number of turns to find a random amount of gold.  Watch out for the hidden tnt or you will lose. 5/22/2019_

#### By _**Mathew Akre, Colton, Justin, Liz**_

## Description

_This program will first ask for a name from the user. You will be redirected to a rules page. Then you will be redirected to the game.  The game page will show a 10x10 button grid. Click the buttons to find the hidden gold. Watch out for the hidden tnt or you will lose. After a certain amount of turns you will lose.  However finding a plot of gold will save one turn._

## Recreate SQL Database
```sql
CREATE DATABASE gold_rush;
USE gold_rush;
CREATE TABLE players (id serial PRIMARY KEY, name VARCHAR(255));
CREATE TABLE prospectors (id serial PRIMARY KEY, phrases VARCHAR(255), win tinyint(1), lose tinyint(1), intro tinyint(1);
```

## Specs
|Behavior|Input|Output|
|-|-|-|
|Create 10x10 grid|for(int i = 0; i < 10; i++){for(int j = 0; j < 10; j++){}}|Makes a 10x10 grid|
|Give gold a value on the grid|if(squareType == 10)|goldCount++|
|Give tnt a value on the grid|if(squareType == -1)|tntCount++|
|Click on a tnt button will redirect to LostGameTnt.cshtml|Click on tnt|Redirect to Tnt LostGameTnt page|
|Turn counter = 5 will redirect to LostGameMoves.cshtml|Click 5 times| Redirect to LostGameMoves page|
|If all gold has been collected Redirect to WonGame.cshtml|Collect All Gold|Redirect to WonGame page|



## Setup/Installation Requirements

* _Clone Github repository_
* _Open the command line_
* _Change the directory to the Desktop_
* _Change the directory to the file GoldRush_
* _Open MAMP and start server_
* _Open WebSart page if it didn't open already_
* _Click on tools drop down menu bar and click on phpMyAdmin_
* _Click on the Import tab to import the database from this project_
* _Or redirect to the Recreate SQL Database section to make the Database_
* _Change the directory to GoldRush_
* _Use the Command dotnet run and copy the localhost5000 link_
* _Paste the link into the url to open the Webpage_

## Support and contact details

_mwakre29@gmail.com_

## Technologies Used

_C#_
_MySQL_
_.NetCore SDK_
_MAMP_
_HTML_
_CSS_
_JavaScript_
_JQuery_
### License

*This project is under the MIT License*

Copyright (c) 2019 **_Mathew Akre, Colton, Justin, Liz_**
