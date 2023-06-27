namespace WalletApp.Application.EventHandlers;

public abstract class BaseEventHandler<TEventArgs> where TEventArgs : EventArgs
{
    public event EventHandler<TEventArgs> OnCreate; 
    public event EventHandler<TEventArgs> OnUpdate; 
    public event EventHandler<TEventArgs> OnDelete;

    public void CreateInvoke(object sender, TEventArgs args)
    {
        OnCreate?.Invoke(sender, args);
    }
    
    public void UpdateInvoke(object sender, TEventArgs args)
    {
        OnUpdate?.Invoke(sender, args);
    }
    
    public void DeleteInvoke(object sender, TEventArgs args)
    {
        OnDelete?.Invoke(sender, args);
    }
}