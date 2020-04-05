## 反射小结
- 反射概念：是一个动态获取程序集，加载里面的类型信息，创建类型实例，调用实例成员的过程
- 常用动态加载程序集的方法:
### 1. `Assembly.Load()`查找步骤
    >> 先根据强命名来加载程序集，先会在GAC中查找程序集
    >> 当没有指定强命名或指定不正确时，会在`codeBase`元素指定的路径中找
    >> 没有找到，又会按以下规则查找:(假设你的应用程序目录是C:\AppDir,<probing>元素中的privatePath指定了一个路径Path1,你要定位的程序集是AssemblyName.dll则CLR将按照如下顺序定位程序集)
    >> ***1.C:\AppDir\AssemblyName.dll***
    >> ***2.C:\AppDir\AssemblyName\AssemblyName.dll***
    >> ***3.C:\AppDir\Path1\AssemblyName.dll***
    >> ***4.C:\AppDir\Path1\AssemblyName\AssemblyName.dll***
如果以上方法不能找到程序集，会发生编译错误，如果是动态加载程序集，会在运行时抛出异常！
### 2.`Assembly.LoadFrom()`
    该方法会先打开指定的程序集文件，获取其中的程序集版本，名称，区域，公钥标识信息，根据这些信息内部再调用`Assembly.Load()`方法，可能加载目标程序集中的所有依赖，但不能加载相同程序集的不同版本。
### 3.`Assembly.LoadFile()`
    该根据路径获取指定的程序集信息，但不会加载目标程序集的依赖，可加载相同程序集的不同版本。
