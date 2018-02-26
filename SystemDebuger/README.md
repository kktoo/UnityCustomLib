封装系统debug方法，优点：
方便一句设置开关；
使用dll的形式，可以双击log跳转定位代码行。
 
工程引用了UnityEngine库，在:Unity\Editor\Data\Managed 目录中

项目的目标框架为.Net Framework 3.5
3.5以下visual studio 无法打包成DLL 
3.5以上Unity3d 运行会报错.
