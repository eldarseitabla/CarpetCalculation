# CarpetCalculation


```txt
Begin "Carpet"

	 //Declare Global Variables
         Define variable noOfSqMetres as Real 
         Define variable pricePerSqMetre as Real  
         Define variable totalCarpetCost as Real
         Define variable existingCustomer as Boolean
         Define variable deliveryCharge as Integer
         Define variable deliveryZone as Character
         Define variable userResponse as Boolean //*** Additional Code

         //Declare Global Constants
         Define Constant variable DISCOUNT as Real = 0.95
         Define Constant variable THRESHOLD as Integer = 200
         Define Constant variable ZONENDCHARGE as Integer = 5
	 Define Constant variable ZONESDCHARGE as Integer = 10
	 Define Constant variable ZONESD as Character = "SD"
         Define Constant variable ZONEND as Character = "ND"

//Start of carpet calculation feature/module/method

Begin "Carpet Calculation"

     Do Loop

	 Call "Initialisation of Variables Module"
         Call "Input Customer Order Details Module"
         Call "Calculate Initial Carpet Cost Module"

         if existingCustomer == true then

            //Assign value/calculation to the right to the variable to the left 

            totalCarpetCost = totalCarpetCost * DISCOUNT
 
         endif.
            
         //Work out delivery charges if applicable

         if totalCarpetCost <= THRESHOLD AND deliveryZone == ZONEND then

             *** totalCarpetCost =  totalCarpetCost + ZONENDCHARGE ***
                
                 deliveryCharge = ZONENDCHARGE

             else
 
                 if totalCarpetCost <= THRESHOLD AND deliveryZone == ZONESD then

                     *** totalCarpetCost =  totalCarpetCost + ZONESDCHARGE ***
                         deliveryCharge = ZONESDCHARGE  
                 endif
         endif.

         //Final CarpetCost Check

         totalCarpetCost =  totalCarpetCost + deliveryCharge

         //Output

         Display "Total Carpet Cost is " totalCarpetCost.
         
         *** Additional Code
         
	 Display "Do you require another Calculation?" 
         Input userResponse //true //false

    While(userResponse == true) //true //false - loop terminates 

End "Carpet Calculation"

Begin "Initialisation of Variables Module"

      Initialise Variables to appropriate default values 

End "Initialisation of Variables Module"

Begin "Input Customer Order Details Module"

         Display "Please enter number of square metres" 
         Accept noOfSqMetres

         Display "Please enter price per square metre" 
         Accept pricePerSqMetre

         Display "Are you an existing customer?" 
         Accept existingCustomer

         Display "Please enter delivery zone" 
         Input deliveryZone

End "Input Customer Order Details Module"

Begin "Calculate Initial Carpet Cost Module"

       totalCarpetCost = noOfSqMetres * pricePerSqMetre

End "Calculate Initial Carpet Cost Module"
       

End "Carpet"
```
