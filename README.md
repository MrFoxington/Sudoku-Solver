Sudoku Solving Program 

Program designed to take a text file input and determin if there is a solution for the Sudoku puzzle provided.

Pass 1 file name into the program on execution (file must be located within same folder as exe)
Only 1 provided puzzle within the provided file.


Rough Solution/Work Breakdown:

	 Verify File Path
	 Read File
		 Validate Proper File Contents
		 Build Sudoku
	 Print Sudoku Base
	 Parse Sudoku
	 Validate current puzzle state
		Identify all valid options for each square (From base puzzel)
     Solve Sudoku
		Locate square with lowest number of options.
		IF 1 option 
			Therefor only 1 possible answer for that square
		IF >1 options 
			Find lowest options count, random decission, follow and see if it leads to valid solution state.
			Limit to only 2 or 3 option states (simplicity)
		THEN 
			Determin new options for effected squares (Row, Column, Block)
        REPEAT TO SOLVE