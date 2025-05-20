The program is just basically a loop that generates searches.

Microsoft has cool down periods between searches sometimes. Adjust minTime and maxTime to change to times for sleeping between searches if the searches are not counted. I use a random number between those values because Microsoft looks for patterns and will cancel your account if they think you are using an automated program.  numberOfRuns is the number of searches per run.


	<appSettings>
		<add key="numberOfRuns" value="40"/>
		<add key="minTime" value="200000"/>
		<add key="maxTime" value="400000"/>
	</appSettings>
