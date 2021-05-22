@fileUploads
Feature: FileUploadTests
	
Scenario: Upload file succesfully from HomePage
Given to choose a file from default filepath
When I click on Upload button
Then file should sucessfully upload

Scenario: Hover to Tools section and upload widget file
Given to choose a file from default filepath
When I hover mouse over Tools section to select Upload Widget option
And I click on Upload button
Then widget should sucessfully upload