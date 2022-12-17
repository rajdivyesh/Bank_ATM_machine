# Bank_ATM_machine
OPEN prjWinCsFinalExam.csproj 

All the functionalities & use case are mentioned below.
At startup : The form reads and verifies the client number in the table
For the number’s verification:
- If the number does not exist: a box message "Number not found"
- If the number exists, the form displays 'Welcome' the customer's name
For PIN verification:
- If the pin is incorrect: a box message "Incorrect Pin, try again"
- If the pin is correct, the choice of the transaction begins
For the choice of transaction:
- The choice of Consult is selected by default,
- When Deposit or Withdraw are selected, the textbox appears
 - To Deposit (validate the amount between $2 and $20000 with messageBox)
 - To Withdraw: the following validations must be made (messagebox)
 - Minimum amount must be $20
 - Maximum amount must be $500
 - Amount must be a multiple of 20
 - Amount must be less than the balance
 To complete the transaction:
- Update account information
- The Terminer button will update the data (by writing the table to the file)
2 – Technical considerations
The structures and data sources for this program will be:
 -> An Account (struct) structure (Number, Client, Pin and Balance)
 -> An array (tabAccounts) of type Account of maximum size 25
• A text file(Bank.txt)
2 – Technical considerations
The structures and data sources for this program will be:
1. An Account (struct) structure (Number, Client, Pin and Balance)
1. An array (tabAccounts) of type Account of maximum size 25
• A text file(Bank.txt)
