﻿Feature: DownloadDropbox
	In order to save content to an Online Server
	As a Warewolf User
	I want to be to backup/move files to a dropbox account


Scenario: Open new Dropbox Tool
	Given I open New Workflow
	And I drag DropboxDownload Tool onto the design surface
    And DropboxDownload New is Enabled
	And DropboxDownload Edit is Disabled
	And DropboxDownload Local File is Enabled
	And DropboxDownload File is Enabled
	When DropboxDownload I Click New
	Then the New DropboxDownload Source window is opened
	
Scenario: Editing Dropbox Tool
	Given I open New Workflow
	And I drag DropboxDownload Tool onto the design surface
    And DropboxDownload New is Enabled
	And DropboxDownload Edit is Disabled
	And DropboxDownload Local File is Enabled
	And DropboxDownload File is Enabled
	When DropboxDownload I Select "Drop" as the source
	Then DropboxDownload Edit is Enabled
	And DropboxDownload I Click Edit
	Then DropboxDownload the "Drop" Dropbox Source window is opened

Scenario: Change Dropbox Source
	Given I open New Workflow
	And I drag DropboxDownload Tool onto the design surface
    And DropboxDownload New is Enabled
	And DropboxDownload Edit is Disabled
	When DropboxDownload I Select "Drop" as the source
	Then DropboxDownload Edit is Enabled
	And I set Download Dropbox Local File equals "E:\test.txt"
	And I set Download Dropbox File equals "Home.txt"
	When Download I change source from "Drop" to "BackupSource"
	Then Download Local File equals ""
	And Download Dropbox File equals ""