设计模式分为3种类别:创建型、结构型和行为型
创建型：抽象工厂创建单例原型
结构型：代理适配桥接享元组合装饰外观
行为型：观察者责备访问者状态，命令中介解释模版迭代策略


创建型模式抽象了实例化过程，将一个系统独立于于如何创建、组合和表示他的那些对象.将系统使用哪些具体类的信息封装起来,隐藏这些类的实例是如何被创建和组织的，外界对于这些对戏那个只知道他们共同的接口，不清楚具体的实现细节
创建型模式隐藏了这些类的实例是如何被创建和放在以前，整个系统关于这些对象所知道的是由抽象类所定义的接口。
这样，创建型模式在创建了什么、谁创建它、它是怎么被创建的，以及何时创建这些方面提供了很大大灵活性。
var obj = simpeMethoe.create("flag");
var obj = {};
var obj = concreteFactory.crate();
var obj = director.getResult();
var obj = prototype.clone();
var obj = concreteFactory.crate();

1.简单工厂模式是由一个工厂对象决定创建出哪一种产品类的实例。简单工厂模式是工厂模式家族中最简单实用的模式，可以理解为是不同工厂模式的一个特殊实现。

2.工厂方法(Factory Method)模式的意义是定义一个创建产品对象的工厂接口，将实际创建工作推迟到子类当中。核心工厂类不再负责产品的创建，这样核心类成为一个抽象工厂角色，仅负责具体工厂子类必须实现的接口，这样进一步抽象化的好处是使得工厂方法模式可以使系统在不修改具体工厂角色的情况下引进新的产品。此模式的核心精神是封装类中不变的部分，提取其中个性化善变的部分为独立类，通过依赖注入以达到解耦、复用和方便后期维护拓展的目的

3.抽象工厂模式:向客户端提供一个接口，使客户端在不必指定产品的具体的情况下，创建多个产品族中的产品对象

4.单例模式：单例模式可以保证系统中一个类只有一个实例而且该实例易于外界访问，从而方便对实例个数的控制并节约系统资源

5.原型模式：由当前对象直接clone一个对象，避免该对象的再次初始化。

6.建造者模式：将一个复杂对象的构建与它的表示分离，使得同样的构建过程可以创建不同的表示。



结构型设计模式是从程序的结构上解决模块之间的耦合问题。包括以下七种模式：

1.Adapte适配器模式：将一个类的接口转换成客户希望的另外一个接口，使得原本不能一起工作的那些类可以以前工作

2.Bridge桥接模式：将抽象部分与实现部分分离，使它们都可以独立的变化。减少因变化带来的代码的修改量。

3.Composite组合模式：将对象组合成树形结构以表示“部分-整体”的层次结构。Composite模式使得客户对单个对象和组合对象的使用具有一致性。从而解决了解决客户程序与复杂对象容器的解耦，即：通过继承统一的接口，我们可以将容器对象及其子对象看成同一类对象使用，以减少对象使用中的复杂度。

4.Decorator装饰模式：动态地给一个对象添加一些额外的职责。就增加功能来说，Decorator模式相比生成子类更为灵活。

5.Facade外观模式：为子系统中的一组接口提供一个一致的界面，简化接口。

6.Flyweight享元模式：运用共享技术有效地支持大量细粒度的对象。

7.Proxy代理模式：为其他对象提供一种代理以控制这个对象的访问。解决直接访问某些对象是出现的问题。
在需要用比较通用和复杂的对象指针代替简单的指针的时候，使用 Proxy模式。下面是一些可以使用Proxy模式常见情况：
1) 远程代理（Remote  Proxy）为一个位于不同的地址空间的对象提供一个本地的代理对象。这个不同的地址空间可以是在同一台主机中，也可是在另一台主机中，远程代理又叫做大使(Ambassador)
2) 虚拟代理（Virtual Proxy）根据需要创建开销很大的对象。如果需要创建一个资源消耗较大的对象，先创建一个消耗相对较小的对象来表示，真实对象只在需要时才会被真正创建。 
3) 保护代理（Protection Proxy）控制对原始对象的访问。保护代理用于对象应该有不同的访问权限的时候。
4) 智能指引（Smart Reference）取代了简单的指针，它在访问对象时执行一些附加操作。
5) Copy-on-Write代理：它是虚拟代理的一种，把复制（克隆）操作延迟到只有在客户端真正需要时才执行。一般来说，对象的深克隆是一个开销较大的操作，Copy-on-Write代理可以让这个操作延迟，只有对象被用到的时候才被克隆。



行为型模式涉及到算法和对象间的职责分配，不仅描述对象或类的模式，还描述它们之间的通信方式，刻划了运行时难以跟踪的复杂的控制流，它们将你的注意力从控制流转移到对象间的关系上来。

1.职责链模式（Chain of Responsibility）：将对象连成一条链，并沿着这条链传递请求，直到有一个对象处理它为止。使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。职责链可简化对象的相互连接，它
们仅需保持一个指向后继者的引用，而不需要保持所有候选者的引用，链中对象不用知道链的结构，接受者和发送者都没有对方的明确信息。可以通过在运行时刻动态的增加或修改链来动态的改变处理一个请求的职责；不能保证请求一定
被接受，一个请求也可能因链没有被正确配置而得不到处理。

2.命令模式（Command）：将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可撤销的操作。别名动作（Action），事务（Transaction）。和很多设计模式一样，命令模式在
你的请求和处理之间加上了一个中间人的角色，来达到分离耦合的目的。

总结：命令模式将调用操作的请求对象和知道如何实现操作的接受对象解耦；具体命令角色可被不同的请求者角色重用，它可将多个命令装配成一个复合命令，增加新的具体命令角色无需改变已有的类。Gof总结命令模式适用以下情况：
（1）需要抽象出待执行的动作，然后以参数的形式提供出来（类似于过程设计中的回调机制）,命令模式正是回调机制的一个面向对象的替代品。
（2）在不同的时刻指定、排列和执行请求。一个命令对象可以有与初始请求无关的生存期。
（3）需要支持取消操作
（4）支持修改日志功能，支持事务操作。从面向对象角度看命令模式是不完美的，命令角色仅仅包含一个方法，是将函数层的角色提升到了类的层面，但命令模式很成功的解决了很多问题，遍布在Struts中。


3.解释器模式（Interpreter）：定义语言（使用规定格式和语法的代码）的文法，并且建立一个解释器来解释该语言中的句子。它属于类行为模式。解释器模式提供一种简单方法来执行语法且容易修改和扩展。一般系统中很多类使用相似
的语法，可以使用一个解释器来代替每一个规则实现一个解释器。在解释器中不同规则是由不同类实现的，从而使添加一个新的语法规则简单化，但对于复杂语法难以维护。


4.迭代器模式（Iterator）：提供一种方法顺序访问一个集合中各个元素，而又不暴露该对象的内部表示。别名：游标（Cursor）。

5.中介者模式（Mediator）：用一个中介对象封装一系列的对象交互。中介者使各对象间不需要显式的相互引用，从而使其松散耦合，而起可以独立的改变它们之间的交互。

总结：广泛应用的MVC也算是中介者模式在框架设计中的一个应用（控制层是位于表现层和模型层之间的中介者）。中介者模式在结构上和观察者模式、命令模式相似，而应用目的与外观模式相似。在结构上，中介者模式与观察者模式和命
令模式都添加了中介对象——只是中介模式去掉了后两者行为上的方向。但观察者模式中的观察者、命令模式中的命令都是被客户所知的，具体哪个观察者、应用都是由客户来指定的，而大多中介者角色对客户是透明的，造成这种区别的原
因是它们要达到的目的不同。从目的上看，命令模式与外观模式相似；但外观模式是介于客户程序与子系统之间的，而中介者模式是介于子系统与子系统之间的；前者将复杂的逻辑提取出一个统一的接口，简化客户对逻辑的使用，而后者
的加入并没有改变客户原有的使用习惯，它是隐藏在原有逻辑后面的，使得代码逻辑更加清晰可用。中介者模式最大的好处是将同事角色解耦，简化原有系统的通信协议——将原有的多对多变为一对多，提高了代码的可复用性。在使用中介
者模式时要注意控制中介者角色的大小。

6.备忘录模式（Memento）：在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，以后可将该对象恢复到原先保存的状态。别名：Token。

7.观察者模式（Observer）：定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖它的对象都得到通知并自动更新。别名：Dependents（依赖），发布-订阅（Publish-subscribe）。

8.状态模式（State）：允许一个对象在其内部状态改变时改变它的行为，对象看起来似乎修改了它的类。别名：状态对象。
协作：Context将与状态相关的请求委托给当前的ConcreteState对象处理，也可将自身作为一个参数传递传递给以处理该请求的状态对象，从而使状态对象在必要时可访问Context。Context是客户使用的主要接口，客户可用状态对象来配
置一个Context，一旦Context配置完毕，它的客户不再需要直接与状态对象打交道。Context和ConcreteState子类都可决定哪个状态时另外哪一个状态的后继者，以及在何种条件下进行状态转换。

9.策略模式（Strategy）：定义一系列算法，把它们一个个封装起来，并且使它们可相互替换，本模式使得算法可独立于使用它的客户而变化。别名：政策（policy）。

10.模版方法模式（Template Method）:定义一个操作中算法的骨架，而将一些步骤延迟到子类中，使得子类可以不改变算法的结构即可重定义该算法的某些特定的步骤。模版方法是一种基本代码复用技术，在类库中尤为重要，它们提取
了类库中的公共行为。算法的结构可理解为根据需求设计出来的业务流程，特定的步骤就是指那些可能在内容上存在变数的环节。

11.访问者模式（Visitor）：表示以作用于对象结构中各元素的操作，它使你可以在不改变各元素的类的前提下定义作用于这些元素的新操作。

总结：行为模式涉及到算法和对象职责间的分配，行为类模式采用继承机制在类间分派行为，Template Method和Interpreter是类行为模式。行为对象模式使用对象复合而不是继承，一些行为对象模式描述了一组相互对等的对象如何相互协
作以完成其中任何一个对象都单独无法完成的任务，如Mediator在对象间引入一个mediator对象提供了松耦合所需的间接性；Chain of Responsibility提供了更松的耦合，它通过一条候选对象链隐式的向一个对象发松请求，可以运行时刻
决定哪些候选者参与到链中；Observer定义并保持了对象间的依赖关系；其它的行为对象模式常将行为封装封装在一个对象中，并将请求指派给它，Strategy模式将算法封装在对象中，这样可以方面的改变和指定一个对象所使用的算法；
Command模式将请求封装在对象中，这样它就可以作为参数来传递，已可以存储在历史列表中或以其它方式使用；State模式封装一个对象的状态，使得当这个对象的状态对象变化时，该对象可改变它的行为；Visitor模式封装分布于多个
类之间的行为；而Iterator模式则抽象了访问和遍历一个集合中对象的方式。