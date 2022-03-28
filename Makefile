# This is not required in coder - already in image
setup-local:
	- dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI

lint:
	- dotnet format

clean: lint
	- dotnet clean

build: clean
	- dotnet build

test:
	- dotnet test
	- livingdoc test-assembly DotNetExample.Tests/bin/Debug/net6.0/DotNetExample.Tests.dll -t DotNetExample.Tests/bin/Debug/net6.0/TestExecution.json -o test-results/TestOutput.html