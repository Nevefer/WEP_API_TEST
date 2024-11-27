using WebAPITest.DAL;

namespace WEP_API_TEST.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            context = _context;
        }

        //Crearemos un metodo llamado SeederAsync()
        //Este metodo es un MAIN() 
        //Este metodo tendra la responsabilidad de prepoblar diferentes tablas de la BD

        public async Task SeederAsync()
        {
            // Primero; agregare un metodo propio de EF que hace las veces del comando  'update-database'
            // En otras palabras: un metodo que me creara la BD inmediatamente ponga en ejecucion mi API
            await _context.Database.EnsureCreatedAsync();

            //Apartir de aqui vamos a ir creando metodos que me sirvan para prepoblar mi BD
            await PopulateCountriesAsync();

            await _context.SaveChangesAsync();

        }



        #region Private Methods 

        private async Task PopulateCountriesAsync()
        {
            //El metodo Any negado (!) me indica que no hay nda absolutamente en la tabla 
            //EL metodo !Any() me indica si la tabla Countries tiene almenos un registro

            if (!_context.Countries.Any()) 
            {

            }
        }

        #endregion
    }
}
