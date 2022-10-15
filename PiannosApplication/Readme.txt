08/10/2022 : At 9.35pm, 
1000: I have started my building my application and named it "PianosApplication" and saved it in projects folder
1001: just hit the IIS EXPRESS and run the app, it shows welcome page, confirm That I finsihed part1.

1002: Publish to the github


1003:  add movie.cs and updated it id, company, type, color, price
1004: run the command "Install-Package Microsoft.EntityFrameworkCore.SqlServer" but no need of that...had those installed already.
1005  reday for the the scaffolding in ControlerS, let give it a hit...
1006: ooh it is not scaffolde yet, error in appsetings.json.. forget to add connectionstring... now rebuld it...
1007: 1 suceeded, 0 skipped 0 failed, another trying to scaffold again, now problem is in startup.cs file, mistakenly
      added MvcMovieContext inspite of PianosApplication, Fixed this problem and giveit another try for scaffold.
1008: Great, sucessfully scaffolded it.
1009: Tested the app, running sucessfully.
1010: Publishing to the the github.
1012: Add migration and update database and now let move to the next step.

1013: Update database and seed the data into database, addded five entries in first try, and added 
      the seed initializer, in drop down of IIS EXPRESS, clicked on PianosApplication and it is running sucessfully.

1014: Update database, trying to add another five entries in SeedData.cs file, saved it and rebuild the app, 
      it did not update on browser, oooh, forget to delete all entries on browser that I've added before.

1015: Updated page of Privacy to About Us and described the details of my Pianos Company (tried to show some creativity).
