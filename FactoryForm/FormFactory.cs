using System.Reflection;

namespace FactoryForm;

public class FormFactory
{
    //作为窗体容器
    private static readonly List<Form> _forms = new();
    //作为缓存类型
    private static readonly List<Type> _types;

    static FormFactory()
    {
        //获取程序集库文件拿到相关的类文件
        var ass = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "FactoryForm.dll");
        //从所有的类中选出为Form的类,并赋值给_types字段
        _types = ass.GetTypes().Where(t => t.BaseType.Name == "Form").ToList();
    }

    public static Form CreateForm(string formName)
    {
        //创建前先隐藏所有窗体
        HideFormAll();
        //创建窗体前先从容器中查找是否存在,有就直接返回
        var form = _forms.Find(m => m.Name == formName);
        if (form == null)
        {
            //从缓存类型中查找出相应类型
            var type = _types.Find(m => m.Name == formName);
            //创建实例
            form = (Form) Activator.CreateInstance(type);
            //加入窗体容器中
            _forms.Add(form);
        }
        //返回查找出来的或是创建出来的窗体
        return form;
    }

    public static void HideFormAll()
    {
        _forms.ForEach(m => m.Hide());
    }
}