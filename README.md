# Procedural-Cities

This project aims to provide a framework and a solid implementation of different techniques for generating complete seamless procedural cities with interiors for all buildings.

Small demo: https://www.youtube.com/watch?v=n1eZOV8r_g4

This project was done as a master thesis at LTH, link to thesis is available here: http://lup.lub.lu.se/luur/download?func=downloadFile&recordOId=8929185&fileOId=8929189

The source code is available to everyone under the MIT licence and you're very welcome to clone or fork the reposity, but keep in mind that it is mostly a proof-of-concept and the code is hardly optimized or refined.

Most parameters are accessible from the "Spawner" blueprint-class, one is spawned in the default map, so edit the values inside of that. Some parameters can be found in ProcMeshActorBP, PlotBuilderBP and HouseBuilderBP. The most interesting parameters to change might be length, maximum turn rate for roads and heatmap settings.

Starting the project generates the city, the defalt character can either walk (with collisions enabled) or fly (with collisions disabled), switch by pressing R. 

