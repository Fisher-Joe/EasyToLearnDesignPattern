# 白话设计模式 - 简单上手设计模式
Easy To Learn DesignPattern

本文旨在使用最简单的大白话语言，最简单的代码让人学习设计模式（最起码是我）

说明：

1. 本文的所有内容都是基于引用文章的再次整理，后续版本也将以此为基础进行扩展和丰富；
2. 为什么本文中的例子没有改写成C#？其实原作者使用的例子的语言一看即懂不与理解冲突，后续的实例，我将以C#为例；

注意：

1. 您必须有一定的开发经验才能更好的理解该系列的文章；
1. 如果你发现某个设计模式，你无法理解，那么请多搜索一下，或者跳下一个看，不要纠结某一个上面；
1. [OOP设计原则][p0]是所有设计模式的总纲，如果你够历害，不用看设计模式，只看这个就行了；
1. 设计模式解决的是变化点，如果没有变化，就用不上它了；
1. 有的时候要反设计模式，并不是说必须遵守；

## 0. 总则

[设计模式(零)：OOP设计原则(设计模式总纲)][p0]

## 1. 创建模式 -- 花式创建对象

[设计模式(一)：工厂模式 简单工厂|静态工程、工厂方法|多工厂、抽象工厂][p11]

[设计模式(二)：单例模式][p12]

[设计模式(三)：建造者模式Builder与原型模式Prototype][p13]


## 2. 结构模式 -- 包一层

[设计模式(四)：适配器模式 Adapter 类适配器、对象适配器、接口适配器][p21]

[设计模式(五)：装饰器模式(Decorator)和代理模式(Proxy)|委托模式(Delegater)][p22]

[设计模式(六)：外观模式(Fecade)与桥接模式(Bridge)详解][p23]

[设计模式(七)：组合模式(Composite)与享元模式(Flyweight)详解][p24]

[设计模式(八)：过滤器模式(Filter)及Kotlin的Filter模式][p25]

## 3. 行为模式  -- 无限责任(方法)转移(到其它的类里)


[设计模式(九)：策略模式(Strategy)与模板模式(Template)详解及二者间区别介绍(两种父子类行为模式)][p31]

[设计模式(十)：观察者模式|迭代器模式|责任链模式(Chain of Responsibility Pattern)|命令模式(四种类间行为模式)][p32]

[设计模式(十一)：备忘录模式(Memento)|状态模式(State) - (两种类状态行为模式)][p33]

[设计模式(十二)：中介模式|访问者模式|解释器模式(三种中间类行为模式)][p34]

## 参考

[p0]: ./doc/0.Guidline.md "设计模式(零)：OOP设计原则(设计模式总纲)"

[p11]: ./doc/1.1.Factory.md "设计模式(一)：工厂模式 简单工厂|静态工程、工厂方法|多工厂、抽象工厂"
[p12]: ./doc/1.2.Singleton.md "设计模式(二)：单例模式"
[p13]: ./doc/1.3.Builder.Prototype.md "设计模式(三)：建造者模式Builder与原型模式Prototype"

[p21]: ./doc/2.1.Adapter.md "设计模式(四)：适配器模式 Adapter 类适配器、对象适配器、接口适配器"
[p22]: ./doc/2.2.Decorator.Proxy.Delegater.md "设计模式(五)：装饰器模式(Decorator)和代理模式(Proxy)|委托模式(Delegater)"
[p23]: ./doc/2.3.Fecade.Bridge.md "设计模式(六)：外观模式(Fecade)与桥接模式(Bridge)详解"
[p24]: ./doc/2.4.Composite.Flyweight.md "设计模式(七)：组合模式(Composite)与享元模式(Flyweight)详解"
[p25]: ./doc/2.5.Filter.md "设计模式(八)：过滤器模式(Filter)及Kotlin的Filter模式"

[p31]: ./doc/3.1.Strategy.Template.md "设计模式(九)：策略模式(Strategy)与模板模式(Template)详解及二者间区别介绍(两种父子类行为模式)"
[p32]: ./doc/3.2.Observer.Iterator.Chain.Command.md "设计模式(十)：观察者模式|迭代器模式|责任链模式|命令模式(四种类间行为模式)"
[p33]: ./doc/3.3.Memento.State.md "设计模式(十一)：备忘录模式(Memento)|状态模式(State) - (两种类状态行为模式)"
[p34]: ./doc/3.4.Mediator.Visitor.Interpreter.md "设计模式(十二)：中介模式|访问者模式|解释器模式(三种中间类行为模式)"

[https://blog.csdn.net/shenpibaipao/article/details/77162732](https://blog.csdn.net/shenpibaipao/article/details/77162732)