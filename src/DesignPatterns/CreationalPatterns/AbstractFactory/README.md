# Abstract Factory Design Pattern

## Sources:

* https://en.wikipedia.org/wiki/Abstract_factory_pattern
* https://www.youtube.com/watch?v=v-GiuMmsXj4&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc&index=5&ab_channel=ChristopherOkhravi
* https://refactoring.guru/design-patterns/abstract-factory
* GoF Book

## Type: `Creational`

The **Abstract Factory** pattern is useful when we need to create families of related or dependent objects. For
example, in a UI system, we may have `Button` and `Dialog` classes, each with implementations for **Windows** and
**Linux**. By using the **Abstract Factory** pattern, we can create these related products in a structured and
consistent way.

## Implementation:

First, let's define our **products**, `Button` and `Dialog`, both of which have implementations for Windows and
Linux. These will serve as our **product interfaces**.

```csharp
// Contract for Button, which is one of our products.
public interface Button
{
    void SetText(string text);
    void Render();
}

// Contract for Dialog, which is another product.
public interface Dialog
{
    void SetButton(Button button);
    void Render();
}

// Concrete implementation of the Button product for Windows.
public class WinButton : Button
{
    public void SetText(string text)
    {
        // Sample implementation.
    }
    
    public void Render()
    {
        // Sample implementation.
    }
}

// Concrete implementation of the Button product for Linux.
public class LinuxButton : Button
{
    public void SetText(string text)
    {
        // Sample implementation.
    }
    
    public void Render()
    {
        // Sample implementation.
    }
}

// Imagine a similar implementation for the Dialog class.
```

Now that we have defined our **products**, we need an **abstract factory** that provides methods for creating related
objects.

> **Note:** The term **"abstract"** here does *not* necessarily refer to the `abstract` keyword in languages like
> `C#`. Instead, it signifies a **contract** or interface that ensures consistency across multiple factories.

```csharp
// The factory can be implemented as an abstract class or an interface.
public interface IElementsFactory 
{
    // These methods return abstract product instances.
    Button CreateButton();
    Dialog CreateDialog();
}

// Concrete factory implementing the abstract factory. 
// This factory will create UI elements specific to Windows.
public class WinElementsFactory : IElementsFactory
{
    public Button CreateButton()
    {
        return new WinButton();
    }
    
    public Dialog CreateDialog()
    {
        return new WinDialog();
    }
}

// Concrete factory implementing the abstract factory. 
// This factory will create UI elements specific to Linux.
public class LinuxElementsFactory : IElementsFactory
{
    public Button CreateButton()
    {
        return new LinuxButton();
    }
    
    public Dialog CreateDialog()
    {
        return new LinuxDialog();
    }
}
```

### **How the Client Uses the Factory**

The client code can use our **factory abstraction** to remain **decoupled** from the specific implementations of
UI components. The client can then choose the appropriate **factory implementation** at **runtime** or **compile time**
to support either **Linux** or **Windows**.

---

## `Additional Thoughts`

As mentioned in the `Factory Method` design pattern README, a **Dependency Injection (DI) container** can often be
used to achieve similar functionality and decoupling. However, one **key advantage** of the `Abstract Factory` pattern
is that it **groups multiple related objects together** within a single factory, making object creation more
**structured and scalable**.

A great approach is to **register** our `Abstract Factory` in a **DI container**, allowing us to inject the appropriate
factory dynamically.

### **Abstract Factory in Back-End Systems**

I don’t currently have a **strong example** of how the `Abstract Factory` pattern would be used in **back-end systems**.
From my experience, most problems that could be solved with either a **Factory Method** or **Abstract Factory** can often
be **handled with interfaces (contracts) and a simple DI container**.

That being said, this perspective may be influenced by the fact that my **business requirements** have not yet necessitated
the `Abstract Factory` pattern in a back-end setting. There may be cases where it could still be useful, especially when
managing related service dependencies, cloud provider SDKs, or data access layers.

Abstract factory is useful when:

* The set of related objects is tightly bound (e.g., all products in a "family" must work together).
* The creation logic is complex and needs to be encapsulated.

DI containers are more suitable when individual objects can be managed independently.

---

### **Summary**

- The **Abstract Factory** pattern is useful when working with families of related objects.
- It provides an **interface (contract)** for creating products while keeping implementations **decoupled**.
- It is commonly used in UI development but may have **limited applicability in back-end systems** where **DI containers** and **interfaces** often suffice.
- The pattern can still be useful in cases where we need to **group multiple related objects** and **ensure consistency** across them.
