Opmerkingen:
	- Functionaliteit van subdomains werkt enkel op http omdat development ceritificaten geen wildcards ondersteunen. 

	- User secrets moeten op het lokaal pad worden gezet. 

	  OPGELET: Normaal dient de secrets file niet in de repository aanwezig te zijn. Dit is momenteel enkel het geval voor de oplevering.
	  In de repository vindt u een folder met "3024c8e7-0000-0000-b266-b33f42dd88c0" als naam. Deze folder kopieert u naar onderstaand pad:
	  C:\Users\"USER"\AppData\Roaming\Microsoft\UserSecrets
	  (u kan dit pad ook vinden door op de windows toets te duwen en daarna %APPDATA% in te geven)
	
	  Door dit te doen hebt u het secrets bestand lokaal gezet en kan de applicatie gebruik maken van deze secrets. 
	  De applicatie dient enkel in de Development environment gehost te worden. De productie environment gebruikt volgende bestanden:
		GOOGLE_CLOUD_CREDS.json.encrypted
		appsettings.json.encrypted
	  Deze bestanden zijn ecrypted en kunnen enkel op de Google Cloud server decrypt worden en vervolgens gebruikt worden in de Production environment.

	- dropCreateDatabase=false. Indien uitermate nodig of indien er databank problemen optreden kan "dropCreateDatabase=true" worden ingesteld in: "DAL/EF/CityOfIdeasDbContext.cs".


Website URL's
	https://www.cityofidea.be
	http://localhost:5001
	http://127.0.0.1:5001

Accounts      
	UserName = "Tree_Company",	        
	Email = "sam.geens@student.kdg.be",
	Password="Test-1"		       
	FirstName = "Tree",
        LastName = "Company",
	Claim= SuperAdmin

        UserName = "District_Mechelen",
        Email = "brecht.pallemans@gmail.com",		       
        Password="Test-1",
        FirstName = "District",
        LastName = "Mechelen",
	Claim= Admin

	        
        UserName = "District_Antwerpen",
        Email = "robbe.dumont@student.kdg.be",
        Password= "Test-1",
        FirstName = "District",
        LastName = "Antwerpen",
	Claim= Admin

        UserName = "Arne_Cools",
        Email = "arne.cools@student.kdg.be",
        Password= "Test-1",
        FirstName = "Arne",
        LastName = "Cools",
	Claim= Moderator project 1

        UserName = "Jeroen_Claessens",		       
        Email = "jeroen.claessens@student.kdg.be",		       
        Password= "Test-1",		        
        FirstName = "Jeroen",
        LastName = "Claessens",
 	Claim= Moderator


        UserName = "Bart_Dewever",
        Email = "bart.dewever@student.kdg.be",		        
        Password= "Test-1",		        
        FirstName = "Bart",
        LastName = "De Wever",
	Claim= Moderator
	        
        UserName = "Jens_VanOrden",		        
        Email = "jens.vanorden@student.kdg.be",		        
        Password= "Test-1",		        
        FirstName = "Jens",
        LastName = "VanOrden",
	Claim= User

        UserName = "Google_Benelux",		        
        Email = "google.benelux@google.be",	        
        Password= "Test-1",	        
        FirstName = "Google",
        LastName = "Benelux",
	Claim= Organisatie
	        
        UserName = "Cronos_Benelux",	        
        Email = "cronos.benelux@cronos.be",	        
        Password= "Test-1",		      
        FirstName = "Cronos",
        LastName = "Benelux",
	Claim= Organisatie