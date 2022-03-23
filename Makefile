clean:
	- dotnet clean

build: clean
	- dotnet build

test:
	- dotnet test
	- livingdoc test-assembly dotnetexample-test/bin/Debug/net6.0/dotnetexample-test.dll -t dotnetexample-test/bin/Debug/net6.0/TestExecution.json -o test-results/TestOutput.html