# 学生选课管理系统

#### 项目介绍

这是一个学生选课信息管理系统，使用VS2010+SQL2008编写。
有登陆窗口、任务栏小化、学生信息管理、学生选课情况、班级统计等功能

![登陆界面](https://gitee.com/uploads/images/2018/0629/164447_08f92471_1935277.png "屏幕截图.png")

![管理界面](https://gitee.com/uploads/images/2018/0629/164532_8bd38135_1935277.png "屏幕截图.png")
#### 软件架构
软件架构说明

使用C#编写，为winform项目

#### 安装教程

1. 直接使用vs2010打开项目中的xk.sln
2. 还原数据库：执行项目下的sql文件，在数据库中执行，为了确认导入成功，请重复执行2次
3. 更改文件数据库连接 Properties/Settings/Settings.Designer.cs
4. 点击 Properties 目录下的Setting.setting修改连接字符串
5. 数据库已经添加一些信息，请在 Users 表中，添加管理员账号。在登陆时方可用管理员账号登陆
[global::System.Configuration.DefaultSettingValueAttribute
连接字符串


![输入图片说明](https://gitee.com/uploads/images/2018/0629/164832_6b4f59f9_1935277.png "屏幕截图.png")
![输入图片说明](https://gitee.com/uploads/images/2018/0629/165111_5d11f466_1935277.png "屏幕截图.png")

#### 使用说明

1. CPublic.cs是公共类文件
其它为实现功能的窗口文件，打开项目后就可以看到。这里不再赘述。

#### 参与贡献

1. 原创 曾建华(深职院老师)
2. 修改优化、加皮肤、增加功能、项目发布 痴者工良


