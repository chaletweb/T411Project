using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T411.Core
{
	public class AuthorizationFactory
    {
        private IHttpConnector _httpConnector;

		public AuthorizationFactory(): this(new HttpConnector())
        {
            
        }
		public AuthorizationFactory(IHttpConnector httpConnector)
        {
            _httpConnector = httpConnector;
        }

        public Authorization GetAuthorizationWithCredential(string username, string password)
        {
            _httpConnector = new HttpConnector();
            var response = _httpConnector.HttpPost("https://api.t411.io/auth", username, password);
			var auth = JsonAdapter.GetAuthorisation(response);

            return auth;
        }

        public Authorization GetAuthorizationFromFile(string filePath)
        {
            //Open file
            string tokenString = FileConnector.ReadFileLine(filePath);
			return GetAuthorization(tokenString);
        }

        public Authorization GetAuthorization(string tokenString)
        {
            var token = new Authorization {Token = tokenString};
            return token;
        }
    }
}
