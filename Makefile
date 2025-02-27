disable-runtime-marshalling-attribute:
	cd $@ && dotnet build
	cd executable && dotnet run -- $(CURDIR)/$@/bin/Debug/net*/$@.dll

library-import:
	cd $@ && dotnet build
	cd executable && dotnet run -- $(CURDIR)/$@/bin/Debug/net*/$@.dll

enum:
	cd $@ && dotnet build
	cd executable && dotnet run -- $(CURDIR)/$@/bin/Debug/net*/$@.dll

customstruct:
	cd $@ && dotnet build
	cd executable && dotnet run -- $(CURDIR)/$@/bin/Debug/net*/$@.dll

.PHONY: disable-runtime-marshalling-attribute library-import enum customstruct
