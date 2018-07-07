# CampStudyNotes
The notes of studying in BingYan summer camp.

-----------------------------------
## A summary of the Markdown grammar

### 标题  
* \#  
字体加粗加大，一个#最大，#越多越小，最多6个,其中，最大与第二大分别可用在文本下加任意数量“==”、“--”来实现  
* {ID}  
标题后加{}可指定标题的ID  
* \[Heading IDs](#文件包含自定义的标题ID/完整URL)  
链接到标题  

### 文本
* \**   \*\*/\__    \__  
加粗文本  
* \*   \*/\_   \_  
斜体文本  
* \*\*\*   \*\*\*/\_\_\_   \_\_\_  
加粗并斜体文本  
* \~\~\~   \~\~\~  
删除线，如：~~~Markdown~~~  
* \*\*\*/\-\-\-/\_\_\_  
分割线  
* \>  
引用，可嵌套自身及别的语法  
* \[^数字]  
添加脚注，放在文本中，后续用“[^数字]：内容”写明脚注  
* \  
可用反斜杠使上述所有特殊字符无效  
* 换行，需键入两或多个空格，然后键入回车

### 列表  
* \-/\*/\+  
用“· ”创建无序列表，用缩进来创建列表嵌套  
* 数字.  
创建有序列表，数字+.，数字不必连续，但开头必须为1，用缩进来创建列表嵌套   
* 通过前后空行在列表中添加其他元素  
* \`\`\`  
行框分列表的开始与结束标签，开始标签后加sh  
* $  
行框分列表的一行  

### 表格  
* \|  
分表格，每两“\|”间为表格一行的一格内容，换行即为表格换行  
* 可在第二行用\|----|--------|加粗标题分割线，通过第二行的\|:---|:----:|---:|则表格对应列的文字靠左，居中，靠右  

### 代码  
* \<html>  
    \<head>  
        \<code>……\</code>  
    \</head>  
代码块  
* \`   \`  
文本中将某一文本格式化为代码  
* \`\`   \`\`  
如果要表示为代码的单词或短语包含一个或多个刻度标记，则可以通过将单词或短语括在双刻度标记（\`\`）中来对其进行转义  
  
### 链接  
* \[文本](链接地址)  
超链接，也可框住的文本内容后再加一“\[]”标签（需在后面指出标签内容）  
* !\[文本](图片路径或URL)  
链接图片，可将其全部用\[]括起，后用()添加图片链接  
* <链接/邮件地址>  
直接将链接或邮件地址链接化  
* 格式化链接同文本  
* \`URL链接\`  
禁用系统自动转义的URL链接  
--------------------------------  
## A summary of Rigidbody Component

### 物理引擎  
#### Rigidbody组件  
##### 功能  
给游戏对象以物理属性
##### 基本属性  
* Mass  
质量，默认值为1  
* Drag  
前进阻力，默认值为0  
* Angular Drag  
旋转阻力，默认值为0.05  
* Use Gravity  
是否使用重力，bool型，默认false  
* Is Kinematic  
是否遵循运动学（是否动态），bool型，默认false，可以受到物理约束，true，只受脚本和动画的影响，不受物理引擎约束，但不等于没有Rigidbody组件，通常用于需要用动画控制的刚体，使不会因为惯性而影响动画  
* Interpolate  
插值方式（平滑方式），默认None（无差值）：不使用差值平滑；Interpolate（差值）：根据上一帧来平滑移动；Extrapolate（推算）：根据推算下一帧物体的位置来平滑移动。  
* Collision Detection  
碰撞检测模式Discrete（离散）：默认的碰撞检测方式，适用于速度较慢的物体，速度较快时会穿过而不触发碰撞；Continuous（连续）：适用于速度较快物体，可以与有静态网格碰撞器的游戏对象进行碰撞检测；Continuous Dynamic（动态连续）：适用于速度较快物体，可以与所有设置了2或3方式的游戏对象进行碰撞检测。    
* Freeze Position/Rotation  
冻结位置/旋转  
##### 刚体变量  
* 声明  
    * 对其它游戏对象的刚体组件进行操作时  
    `public Rigidbody \_rig;`						
    引用一个游戏对象的刚体组件，在检视面板中可在该脚本所挂载的游戏对象中的脚本中对其赋值  
    安全代码：  
    ` 
    if（_rig==null）   
    {   
        Debug.LogError(“The \_rig is null”);    
       return；    
    }  `   
    当刚体组件的引用未赋值时报错    
    * 对自身的刚体组件进行操作时  
    `private Rigidbody _rig=GetComponent<Rigidbody>();`
    声明一个自身刚体组件的引用  
* 成员变量  
    * angularVelocity（角速度）  
    角速度的向量，Vector3类型，方向为刚体旋转轴方向（世界坐标轴）  
    示例代码：`GetComponent<Rigidbody>().angularVelocity=Vector3.up;  `
    注：不建议过多修改，否则会造成模拟不真实  
    * velocity（位移速度）  
    物体位移速度值  
    示例代码：`GetComponent<Rigidbody>().velocity=Vector3.up;`  
    注：不建议过多修改，否则会造成模拟不真实  
    * centerOfMass（重心）  
    Vector3类型，通过调低物体重心可使其不易因其它物体的碰撞或作用力而倒下，若不对其进行设置，则Unity会自动根据collider对其进行计算  
    * detectCollisions（碰撞检测）  
    Bool类型，置为false时即为关闭碰撞检测，不会与任何“物体”发生碰撞  
* 成员方法  
    * 添加力  
        * AddForce（施加力）  
        Vector3类型，为施加力的向量  
	    定义：  
	    `public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)；`  
        force 决定力的方向和大小  
        mode 决定作用力的模式  
        * AddTorque（施加力矩）  
        定义：  
        `public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force);`  
        torque 决定旋转力的大小和旋转轴的方向，旋转方向参照左手定则   
        mode 决定作用力的模式  
        * AddRelativeForce（施加相对力）  
        * AddRelativeTorque（施加相对力矩）  
        * AddExplosionForce（施加爆炸力）  
    > ForceMode介绍  
    > 功能：力的作用方式。枚举类型,有四个枚举成员  
    > 计算公式：    Ft = mv(t) 即 v(t) = Ft/m    
    >F—力的大小	t—间隔时间 	   m—物体质量	   v—物体速度 	 v(t)—v关于t的函数  
    >ForceMode.Force : 持续施加一个力，与重力mass有关，t = 每帧间隔时间，m = mass，可叠加，可被其它力抵消，如重力  
    >ForceMode.Impulse : 瞬间施加一个力，与重力mass有关，t = 1.0f，m = mass  
    >ForceMode.Acceleration：持续施加一个力，与重力mass无关，t = 每帧间隔时间，m = 1.0f  
    >ForceMode.VelocityChange：瞬间施加一个力，与重力mass无关，t = 1.0f，m = 1.0f，只改变速度  
   
    * ClosestPointOnBounds（计算相对刚体的最近点）  
        `public Vector3 ClosestPointOnBounds(Vector3 position);`  
    * 获取速度  
        * GetPointVelocity（获取点坐标系的速度）  
            `public Vector3 GetPointVelocity(Vector3 worldPoint);`  
        * GetRelativePointVelocity（获取基于相对点坐标系的速度）  
            `public Vector3 GetRelativePointVelocity(Vector3 relativePoint);`  
    * 休眠  
        * IsSleeping（是否处于休眠）  
            `public bool IsSleeping();`  
        * Sleep（强制休眠）  
            `public void Sleep();`  
        * WakeUp（唤醒）  
            `public void WakeUp();`  

#### Collider组件  
##### 响应函数  
OnCollisionEnter OnCollisionEnter OnCollisionExit  
都有(Collision collion)参数   
>**Collision**  
>成员变量：  
>relativeVelocity：与碰撞物体的相对线性速度  
>rigidbody：碰撞物体的rigidbody组件  
>collider:碰撞物体的collider组件  
>transform:碰撞物体的transform组件  
>gameObject:碰撞的物体   
>contacts:与碰撞物体的接触的点集，ContactPoint\[]类型，contacts\[0]为接触的第一个点  
>impulse:应用在接触解决的碰撞的总推力  
##### 与子弹间的碰撞处理  
* 碰撞消除（一般）  
`Physics.IgnoreCollision(clone.collider,this.collider);`  
* 碰撞效果  
用射线函数判断是否被击中，并获取子弹击中点  
`if (Physics.Raycast (originPosition, direction, hitInfo, distance)){.....}`  
对该点施加子弹冲击力（先判断是否是刚体）  
`if (hit.rigidbody) hit.rigidbody.AddForceAtPosition(force * direction, hitInfo.point);`  
##### 复合碰撞器  
由基本的碰撞器构成，创建在对应游戏对象的子空游戏对象中（便于单个调整）  
