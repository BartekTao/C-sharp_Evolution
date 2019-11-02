# C#基礎_課程大綱

## 註記
> 要幫我想實作範例
> 我們課程文件的內容**越詳細完整越好**，但講解的時候可以挑著講，每個題目可以有個重要程度⭐來辨識，滿分五顆⭐
> [name=Bartek][time=Wed, Oct 30, 2019 9:21 AM][color=#4bf4cd]
> > 用這種tag回復感覺不錯[name=BartekTao][time=Wed, Oct 30, 2019 9:23 AM][color=#e2b451]

> 我們可以找一些**面試題目**來當教學的參考
> [name=BartekTao][time=Wed, Oct 30, 2019 6:45 PM][color=#F00000]
> > [C# Interview Questions and Answers to Know in 2019](https://dev.to/fullstackcafe/60-c-interview-questions-to-get-job-offer-in-2019-1382)[color=#e2b451]
> > [Top 50 C# Interview Questions With Answers](https://www.softwaretestinghelp.com/c-sharp-interview-questions/)[color=#e2b451]

## 目錄
> [TOC]


## 第一堂課
### Program Structure程式結構
* programs程式, namespaces命名空間, types型別, members成員, and assemblies組件
* 給一個範例程式，講解說明以上內容
* 可搭配dotnet指令做簡單的編譯與執行

### Types
* Value types
* Reference types
![alt text](https://docs.microsoft.com/zh-tw/dotnet/csharp/programming-guide/types/media/index/value-reference-types-common-type-system.png)
* stack and heap
* Casting and type conversions
* Boxing and Unboxing
* String
* Using type dynamic
* Nullable value types
    > see "C# in Depth 4th",section 2.2,p.38
* typed arrays
* Anonymous types
### XML Documentation Comments
* 寫範例，展示程式碼中顯示樣式以及文檔中的顯示樣式
* 輸出文檔
```
<code>
cerf
<example>
<exception>
<list>
<para>
<param>
<paramref>
<typeparam>
<typeparamref>
<premiaaion>
<remarks>
<return>
<see>
<seealso>
<summary>
<value>
```

---

## 第二堂課
### Statements, Expressions, Operators and Indexers陳述式、運算式、運算子索引子
* Statements
* Expressions
* Operators
* Indexers

---

## 第三堂課
### Classes & Structs
* classes & structs
```
Fields
Constants
Properties
Constructors
Events
Finalizers
Indexers
Operators
Nested Types
```

* 修飾詞
類型有哪些
使用時機
* 繼承
* 多型
* Extension Methods
> 感覺知道類型之後在學擴充方法比較好[name=BartekTao][time=Sat, Nov 2, 2019 3:23 PM][color=#4bf4cd]

---

## 第四堂課
### Enumeration types
* 應用場景
* flag
* 反射取值

### Collections(這感覺可以講兩堂課)
* System.Collections
* System.Collections.Generic
* List
* ArrayList
* Array
* Dictionary
* Hashtable
* Hashtable與Dictionary差異
* IEnumerable

---

## 第五堂課
### Interfaces
* 使用場景
* 明確實作

### Generics泛型
* What can be generic?
* Type constraints(約束條件 where)
* Default and typeof operator
* Generics and Attributes

---

## 第六堂課
### 物件導向原則
### 練習周(運用以上學過的東西出個題目)

---

## 第七堂課
### Delegates & Events



---

## 第八堂課
### Iterators
* 使用場景與應用
* yield return
* 好處? [比較與範例](https://ithelp.ithome.com.tw/articles/10193586)
* 舉幾個source code的使用場景
* 實作幾個簡單用應用

---

## 第九堂課
### Linq
* Lambda expressions
### Lazy

---

## 第十堂課
### Asynchronous programming

---

## 第十ㄧ堂課

### Attributes
### RegularExpression

---

## 第十二堂課
### Exceptions and Exception Handling
### 總結實作

---

# .NET
> RESTful需要講解嗎?要的話是屬於哪範圍?[name=BartekTao][time=Sat, Nov 2, 2019 5:57 PM][color=#11f4e9]
## .NET foundation
## 目標 .NET 基礎
### CLI/CLR/CLS
### 自動記憶體管理(GC)
### 基底類別庫(BCL)
---
## 目標 Exceptions and Exception Handling
---
## 目標 Serialization 
---
## 目標 IO
### 記憶體 IO
### DB IO
### 網路 IO
---
## Threading
---
## 目標 Reflection 
> 反射你要在.net講解是嗎? 還是我需要在C#的Attributes提及? 
> [name=BartekTao][time=Wed, Oct 30, 2019 7:04 PM][color=#4bf4cd]
> >可以略提,深入可留到.net 講[name=impg]

---
## 目標 ORM (EntityFramework Core 或 Dapper)
---
## 目標 Web Develop(asp.net core)

---
# 參考資料
[峻歲的bug單](https://esunrm.esunbank.com.tw/redmine/issues/66542)
這個是?發人省思還是修掉算結業?
[純css鯨魚](http://www.subcide.com/experiments/fail-whale/)
[獅子](https://codepen.io/Yakudoo/pen/YXxmYR)

{%vimeo 352588616%}