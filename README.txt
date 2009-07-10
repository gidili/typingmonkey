->TYPING MONKEY<-- 

Evolve an input string from a population of random strings using a genetic algorithm

=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=-=-=

1.*What is TypingMonkey?*

TypingMonkey is a very simple application that does only one thing: it gets an input string from the user then uses a genetic algorithm to evolve a population (size chosen by the user) of random strings into the text entered by the user. 

2.*Do-Different*

In the main loop there is a call to Application.DoMessages(). This is a slight hack to push all the UI messages out of the OS message queue and get the UI to refresh  - this is related to the resource consuming large number of computations we are performing with the genetic algorithm.
The best way of doing this would be starting a BackgroundWorker thread and perform the computation on the other thread without affecting the UI thread. 

3.*Technology and Installation Requirements*

The application has been developed using C# and the .NET Framework 3.5, which is required for the execution:
http://www.microsoft.com/downloads/details.aspx?FamilyId=333325FD-AE52-4E35-B531-508D977D32A6&displaylang=en 

In order to debug/build locally Visual Studio 2008 Professional/Express is required:
http://www.microsoft.com/exPress/download/ 