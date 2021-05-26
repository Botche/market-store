# market-store
Project for store that includes the three types of design patterns.

# About the application
The application represent market store that can register client into online system, make purchases, give discount cards to clients and use them, when purchasing.

## Implemented design patterns
* Creational patterns
	* Factory Method - for CommandFactory
	* Singleton - for the Market class
* Structural patterns
	* Facade - for Paydesk and ClientsPortal
* Behavioral patterns
	* Command - for commands and input

## Comands
* Assignee card [clientName] [cardType]
* Change card [clientName] [cardType]
* Commands info
* Make purchase [clientName] [amount]
* Print info
* Register client [clientName]
* Remove card [clientName]
* Remove client [clientName]
* Exit

## Input/Output
	Input

	Register client Mike
	Register client Alex
	Make purchase Alex 200
	Assignee card Alex bronze
	Make purchase Alex 200
	Change card Alex silver
	Make purchase Alex 200
	Change card Alex gold
	Make purchase Alex 200
	Remove card Alex
	Make purchase Mike 200
	Register client test
	Remove client test
	Print info
	Exit

	Output

	Registered client [Mike] in the market
	Registered client [Alex] in the market
	Purchase value with discount: 200,00
	Assigneed bronze card to Alex
	Purchase value with discount: 196,00
	Change discount card to silver for client Alex
	Purchase value with discount: 190,00
	Change discount card to bronze for client Alex
	Purchase value with discount: 180,00
	Removed discount card from client Alex
	Purchase value with discount: 200,00
	Registered client [test] in the market
	Removed client [test]
	This is market "Ivona"...
	Clients in the market:
	-- Client name: Mike
	-- Client name: Alex
	===========================
