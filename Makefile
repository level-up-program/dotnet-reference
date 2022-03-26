setup:
	- dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI

clean:
	- dotnet clean

build: clean
	- dotnet build

test:
	- dotnet test
	- livingdoc test-assembly DotNetExample.Tests/bin/Debug/net6.0/DotNetExample.Tests.dll -t DotNetExample.Tests/bin/Debug/net6.0/TestExecution.json -o test-results/TestOutput.html