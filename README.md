# Emailr

With Emailr you can create a list of people and teams, compose an html email with attachements and send it to either the whole list, or selected people and teams.
You will see a preview of the html content in the start form and you can select individual people through the listbox to receive the emails.
If no one is selected, the email will be sent to the whole list.

You can add keywords in to the subject, the email content and the attachement filepath to give every mail a personal touch or attach personal files like payrolls.
The keywords will be replaced by the data from the list and compose mail form.

As an example, you can modify the filepaths in the form itself, or create dummy files containing the keywords in the format of the actual files (don't forget to change folder names too).

![Imgur](https://i.imgur.com/vrAYlhc.png)

![Imgur](https://i.imgur.com/ie7xCdG.png)

After clicking the ✓ button, the edited path will be saved and modified for each person while sending.
The subject will look like: `Payroll for 2020/7`

There is an option to add an image to the email and use it inline as e.g. a company logo. 
Just use `<img src="cid:companyLogo">` in the html body of the mail.

The app uses a tls/ssl connection through the .Net.Mail.SmtpClient package to send the mails.
You need to provide the email address, the smtp server and the smtp port through the settings form.
