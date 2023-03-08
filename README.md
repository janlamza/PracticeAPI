# Practice Application
<!-- ABOUT THE PROJECT -->
## O Projektu

Projekt služi kao vježba za izgradnju jednostavnoga backend-a u .NET-u, naglasak je na primjenu najboljih praksi / pattern-a
  
### Ideja :  
* Dating aplikacija
* Korisnik napravi profil, dobije ovlasti korisnika, ima mogućnost uploadanja slika te lajkanja drugih korisnika 
* Admin ima dodatne ovlasti

### Aplikacija omogućuje :
* Autentifikacija (Microsoft Identity)
* Autorizacija (Admin, Member, Moderator role)
* CRUD operacije 
* Spremanje podataka u SQLite bazu
* Spremanje i praćenje korisnikove online prisutnosti putem Tokena 
* Uploadanje fizičke slike na Cloudinary servis, a reference na sliku (Url) u bazu
* Handlanje Errora
* Paginaciju (Cursor based) korisnika
* Automatsko seed-anje korisnika u bazu ako je prazna   
 
 ### Korištene tehnologije :
 * .NET (7.0.102 SDK)
   * Entity framework (7.0.2)
   * Microsoft Identity (7.0.0)
   * SQLite (7.0.2)
   * JwtBearer (6.26.0)
   * AutoMapper (12.0.0)
   * Cloudinary (1.20.0)
 * Postman 

  
  <!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.


