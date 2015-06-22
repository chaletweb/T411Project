namespace T411.Core
{
    public interface IAuthorization
    {
		//Result
		string Token { get; set; }

		// Error
		string Error { get; set; }
		int Code { get; set; }
    }
}