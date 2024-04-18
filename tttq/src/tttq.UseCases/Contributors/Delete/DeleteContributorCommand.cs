using Ardalis.Result;
using Ardalis.SharedKernel;

namespace tttq.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
