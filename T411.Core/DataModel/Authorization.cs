namespace T411.Core
{
	public class Authorization : IAuthorization
    {
        //Result
		public string Token { get; set; }

		// Error
		public string Error { get; set; }
		public int Code { get; set; }
    }
}