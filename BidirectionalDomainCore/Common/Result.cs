namespace Bidirectional.DomainCore.Common
{
    public class Result
    {
        public Result(bool succeeded, IEnumerable<string> errors, OrganizationBusinessUnitUserIDsResponse? data = null)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
            Data = data;
        }

        public bool Succeeded { get; init; }

        public string[] Errors { get; init; }

        public OrganizationBusinessUnitUserIDsResponse? Data { get; init; }

        public static Result Success() => new Result(true, Array.Empty<string>());

        public static Result Failure(IEnumerable<string> errors) => new Result(false, errors);

        public static Result Success(OrganizationBusinessUnitUserIDsResponse? data) => new Result(true, Array.Empty<string>(), data);
    }

    public class OrganizationBusinessUnitUserIDsResponse
    {
        public string? OrganizationID { get; set; }

        public string? BusinessUnitID { get; set; }

        public string? UserID { get; set; }

        public string? BookingStaffID { get; set; }
    }


}
