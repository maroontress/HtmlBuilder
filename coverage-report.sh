#!/bin/sh
dotnet ~/.nuget/packages/reportgenerator/4.1.2/tools/netcoreapp2.0/ReportGenerator.dll --reports:HtmlBuilder.Test/coverage.opencover.xml --targetdir:Coverlet-html
