clean:
	- cd dotnetexample; dotnet clean
	- cd dotnetexample-test; dotnet clean

build: clean
	- cd dotnetexample; dotnet build
	- cd dotnetexample-test; dotnet build

test:
	cd dotnetexample-test; dotnet test
	cd dotnetexample-test/bin/Debug/net6.0; livingdoc test-assembly dotnetexample-test.dll -t TestExecution.json