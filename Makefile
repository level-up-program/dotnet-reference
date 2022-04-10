.PHONY: bootstrap setup update run clean build test cibuild citest
.DEFAULT_GOAL := help

help: 
	echo "Primary goals are build, run, test, verify. 'make run' to execute"

# This is not required in coder - already in image
bootstrap: 
	dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI

setup:
	dotnet restore

lint:
	dotnet format

run:
	dotnet run --project DotNetExample

clean: 
	dotnet clean
	rm -rf ./test-results

build: clean lint
	dotnet build

test: build
	dotnet test --filter "TestCategory!=acceptance"

verify: build
	- dotnet test --filter "TestCategory=acceptance"
	- cp -r DotNetExample.Tests/resources ./test-results
# May need export for M1 Mac Architecture
	- export DOTNET_ROOT=$(which dotnet) & livingdoc test-assembly DotNetExample.Tests/bin/Debug/net6.0/DotNetExample.Tests.dll -t DotNetExample.Tests/bin/Debug/net6.0/TestExecution.json -o test-results/TestOutput.html

cibuild: 
	dotnet build --no-restore

citest:
	dotnet test --no-build --verbosity normal