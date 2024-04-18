using Ardalis.Result;
using Ardalis.SharedKernel;

namespace tttq.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
