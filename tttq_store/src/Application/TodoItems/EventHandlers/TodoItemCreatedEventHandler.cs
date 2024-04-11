using tttq_store.Domain.Events;
using Microsoft.Extensions.Logging;

namespace tttq_store.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("tttq_store Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
