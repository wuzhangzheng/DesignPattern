namespace SingleForm;

public class FormFactory
{
    public static Dictionary<Type, object> dicForm = new();

    public static Form GetForm<T>() where T : Form
    {
        return GetForm(typeof(T));
    }

    public static Form GetForm(Type formType)
    {
        var hasForm = dicForm.TryGetValue(formType, out var formInstance);
        if (!hasForm)
            lock (dicForm)
            {
                if (!hasForm)
                {
                    dicForm.Add(formType, Activator.CreateInstance(formType));
                    hasForm = dicForm.ContainsKey(formType);
                }
            }

        return (Form)dicForm[formType];
    }
}