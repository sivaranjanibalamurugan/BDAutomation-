Select Top (1000) [FirstColumn],
             [SecondColumn],
			 [ThirdColumn],
			 [fourthColumn]
  from [DBAutomation].[dbo].[columns]
  select  TOP(1) [FirstColumn]
  from [DBAutomation].[dbo].[Columns]