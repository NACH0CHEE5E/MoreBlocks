@echo off

:start

echo type 1 to initiate the 1.3.0 to 1.3.1 fix
echo type 2 to quit

set /p op=Type option:
if "%op%"=="1" goto 1.3.0-1.3.1
if "%op%"=="2" goto quit

:1.3.0-1.3.1

del gamedata\types\Bricks.json
del gamedata\types\Buckets.json
del gamedata\types\Coins.json
del gamedata\types\ColouredConcrete.json
del gamedata\types\Concrete.json
del gamedata\types\Dirt.json
del gamedata\types\Grass.json
del gamedata\types\Ice.json
del gamedata\types\MiscBlocks.json
del gamedata\types\MiscItems.json
del gamedata\types\Ores.json
del gamedata\types\Paint.json
del gamedata\types\PaintBlocks.json
del gamedata\types\Sand.json
del gamedata\types\ScienceBags.json
del gamedata\types\SmoothedConcrete.json
del gamedata\types\Stone.json
del gamedata\types\Tools.json
del gamedata\types\TreeLogs.json
del gamedata\types\Planks.json
del gamedata\types\RockPiles.json
echo complete
echo if problems persist join the discord
echo discord.gg/tqFhxhm
pause
goto start

:quit