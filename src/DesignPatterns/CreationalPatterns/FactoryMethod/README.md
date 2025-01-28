# Factory Method Design Pattern

## sources:

* https://refactoring.guru/design-patterns/factory-method
* https://www.youtube.com/watch?v=EcFVTgRHJLM&ab_channel=ChristopherOkhravi
* https://en.wikipedia.org/wiki/Factory_method_pattern
* Gang of four book

### Type: Creational Pattern

This pattern is useful when dealing with classes that have a complex creation process or when you need to use
these classes interchangeably. For example, imagine you want to work with either an `EmailClient` or an
`SmsClient` and be able to switch between them at runtime. The Factory Method design pattern provides a solution
to handle such requirements.

### Implementation

First, you need a common ancestor for `EmailClient` and `SmsClient`. Let’s call it `MessageClient`. This common
ancestor can be an interface or an abstract class. By leveraging polymorphism, you can use any client implementation
without needing to modify the rest of your application.

Next, create an abstract class called `MessageSender`, which will use `MessageClient` to send messages and perform
other business-related operations. However, you still need a way to instantiate a specific implementation of
`MessageClient`. This is where the Factory Method pattern comes into play.

In `MessageSender`, define an abstract method called `CreateMessageClient`, and replace all direct instantiations
of `MessageClient` with calls to this abstract method.

The Factory Method (the `CreateMessageClient` method) defers the responsibility of creating a `MessageClient` instance
to the subclasses of `MessageSender`. The next step is to create concrete implementations like `EmailSender` and
`SmsSender`, which inherit from `MessageSender` and implement the `CreateMessageClient` method accordingly.

### Example:

```csharp
// Common ancestor
public abstract class MessageClient {
    public abstract void SendMessage(string message);
}

// Concrete implementations AKA products.
public class EmailClient : MessageClient {
    public override void SendMessage(string message) {
        Console.WriteLine($"Email sent: {message}");
    }
}

public class SmsClient : MessageClient {
    public override void SendMessage(string message) {
        Console.WriteLine($"SMS sent: {message}");
    }
}

// Abstract factory
public abstract class MessageSender {
    public void Send(string message) {
        var client = CreateMessageClient();
        client.SendMessage(message);
    }

    // factory method
    protected abstract MessageClient CreateMessageClient();
}

// Concrete factories
public class EmailSender : MessageSender {
    protected override MessageClient CreateMessageClient() {
        return new EmailClient();
    }
}

public class SmsSender : MessageSender {
    protected override MessageClient CreateMessageClient() {
        return new SmsClient();
    }
}
```

Keep in mind the primary role of the abstract factory is not to instantiate product, it usually contains some
business logic that relies on the product returned by the factory.

## Additional Thoughts

One potential downside of the Factory Method pattern is the increased number of classes and subclasses it may
introduce. In modern programming languages, there are alternative approaches that achieve similar results more
efficiently:

* Using Delegates: In C#, for instance, you can replace the abstract factory method with a delegate, such as
  `Func<MessageClient>`. This allows you to pass the delegate into your `MessageSender` methods or its constructor.
* Dependency Injection (DI): A DI container can be used to inject the appropriate MessageClient implementation
  into `MessageSender` at runtime, avoiding the need to create numerous subclasses.

Personally, if a DI container is available, I would use it or leverage a Func delegate instead of introducing
extra subclasses.