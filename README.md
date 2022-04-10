# Erin doesn't know .Net...but she's sure gonna try!
This is a very simple solution to demonstrate SpecFlow and living-doc, as well as simple commands for C# outside of Visual Studio.
* "make build" will clean and build this thing
* "make test" will run only unit tests 
* "make verify" will run and generate pretty output for SpecFlow tests in test-results folder
* Actions are configured to build and test on both main and develop
* Actions are configured to publish test results to gh-pages from develop

NOTE: All specflow tests should have a tag of @acceptance to keep them properly segrated for the make file.

M1 MAC USERS: I had to force living doc to install with the correct architecture using -a arm64. I also had to manually set DOTNET_ROOT env var to the location of dotnet (which dotnet).