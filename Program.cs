namespace SessionOOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* part01 */


            //Q1 : A

            //Q2 : B

            //Q3 : B

            //Q4 : B

            //Q5 : D

            //Q6 : A

            //Q7 : B

            //Q8 : A

            //Q9 : D

            //Q10: C

            /*------------------*/

            /* Part02 */

            #region Q1 Part02
            ICircle circle = new Circle(5);
            IRectangle rectangle = new Rectangle(2, 3);

            circle.DisplayShapeinfo();
            rectangle.DisplayShapeinfo();
            #endregion

            #region Q2 Part02
            IAuthenticationService authservice = new BasicAuthenticationService();
            string username = "username";
            string password = "password";
            string role = "admin";
            ;
            bool isAuthenticated = authservice.AuthenticateUser(username, password);
            Console.WriteLine($"authenticated : {isAuthenticated}");

            bool isAuthorizes = authservice.AuthenticateUser(username, role);
            Console.WriteLine($"Authorizes  : {isAuthorizes}"); 
            #endregion





        }
    }
}
