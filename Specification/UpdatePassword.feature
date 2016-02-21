Feature: UpdatePassword
	As an LMS user, I want to update my password

@mytag
Scenario: Successful update password
Given I have launched update password form
	When I enter current password, new password and confirm password
	And I click on update button
	Then password is updated and I see Password update successful message
