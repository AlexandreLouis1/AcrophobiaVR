#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000003 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000004 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000005 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000006 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000007 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000008 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Take(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::TakeIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x0000000A System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderByDescending(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000D TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000E System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000F TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 TSource System.Linq.Enumerable::Last(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000013 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Empty()
// 0x00000014 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000015 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000016 System.Boolean System.Linq.Enumerable::All(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000017 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000018 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x00000019 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001A System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x0000001B TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x0000001C System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x0000001D System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x0000001E System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x0000001F System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000020 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000021 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000022 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000023 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000024 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000025 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000026 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x00000027 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000028 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000029 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002A System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002B System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x0000002C System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x0000002D System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x0000002E System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002F System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000030 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000031 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000032 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000033 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000034 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000035 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000036 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x00000037 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000038 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000039 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003B System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003C System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x0000003D System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x0000003E System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003F System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000040 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000041 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000042 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000043 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000044 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000045 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x00000046 System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x00000047 System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000048 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000049 System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::.ctor(System.Int32)
// 0x0000004A System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::System.IDisposable.Dispose()
// 0x0000004B System.Boolean System.Linq.Enumerable/<TakeIterator>d__25`1::MoveNext()
// 0x0000004C System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::<>m__Finally1()
// 0x0000004D TSource System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x0000004E System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerator.Reset()
// 0x0000004F System.Object System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerator.get_Current()
// 0x00000050 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000051 System.Collections.IEnumerator System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000052 System.Void System.Linq.EmptyEnumerable`1::.cctor()
// 0x00000053 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000054 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000055 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000056 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000057 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000058 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000059 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x0000005A System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x0000005B System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x0000005C TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x0000005D System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x0000005E System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x0000005F System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000060 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000061 System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x00000062 System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x00000063 System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000064 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000065 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000066 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000067 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000068 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000069 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x0000006A TElement[] System.Linq.Buffer`1::ToArray()
// 0x0000006B System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x0000006C System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x0000006D System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000006E System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x0000006F System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000070 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000071 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000072 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000073 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000074 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000075 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000076 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000077 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000078 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000079 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x0000007A System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x0000007B System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x0000007C System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x0000007D System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x0000007E System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x0000007F System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000080 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000081 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000082 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000083 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000084 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000085 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x00000086 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000087 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
// 0x00000088 System.Void System.Collections.Generic.ICollectionDebugView`1::.ctor(System.Collections.Generic.ICollection`1<T>)
// 0x00000089 T[] System.Collections.Generic.ICollectionDebugView`1::get_Items()
static Il2CppMethodPointer s_methodPointers[137] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[137] = 
{
	4184,
	4351,
	4351,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[49] = 
{
	{ 0x02000004, { 75, 4 } },
	{ 0x02000005, { 79, 9 } },
	{ 0x02000006, { 90, 7 } },
	{ 0x02000007, { 99, 10 } },
	{ 0x02000008, { 111, 11 } },
	{ 0x02000009, { 125, 9 } },
	{ 0x0200000A, { 137, 12 } },
	{ 0x0200000B, { 152, 1 } },
	{ 0x0200000C, { 153, 2 } },
	{ 0x0200000D, { 155, 8 } },
	{ 0x0200000E, { 163, 2 } },
	{ 0x02000010, { 165, 3 } },
	{ 0x02000011, { 170, 5 } },
	{ 0x02000012, { 175, 7 } },
	{ 0x02000013, { 182, 3 } },
	{ 0x02000014, { 185, 7 } },
	{ 0x02000015, { 192, 4 } },
	{ 0x02000016, { 196, 21 } },
	{ 0x02000018, { 217, 2 } },
	{ 0x02000019, { 219, 2 } },
	{ 0x06000004, { 0, 10 } },
	{ 0x06000005, { 10, 10 } },
	{ 0x06000006, { 20, 5 } },
	{ 0x06000007, { 25, 5 } },
	{ 0x06000008, { 30, 1 } },
	{ 0x06000009, { 31, 2 } },
	{ 0x0600000A, { 33, 2 } },
	{ 0x0600000B, { 35, 2 } },
	{ 0x0600000C, { 37, 1 } },
	{ 0x0600000D, { 38, 3 } },
	{ 0x0600000E, { 41, 2 } },
	{ 0x0600000F, { 43, 4 } },
	{ 0x06000010, { 47, 4 } },
	{ 0x06000011, { 51, 4 } },
	{ 0x06000012, { 55, 3 } },
	{ 0x06000013, { 58, 1 } },
	{ 0x06000014, { 59, 1 } },
	{ 0x06000015, { 60, 3 } },
	{ 0x06000016, { 63, 3 } },
	{ 0x06000017, { 66, 2 } },
	{ 0x06000018, { 68, 2 } },
	{ 0x06000019, { 70, 5 } },
	{ 0x06000029, { 88, 2 } },
	{ 0x0600002E, { 97, 2 } },
	{ 0x06000033, { 109, 2 } },
	{ 0x06000039, { 122, 3 } },
	{ 0x0600003E, { 134, 3 } },
	{ 0x06000043, { 149, 3 } },
	{ 0x06000057, { 168, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[221] = 
{
	{ (Il2CppRGCTXDataType)2, 2188 },
	{ (Il2CppRGCTXDataType)3, 10278 },
	{ (Il2CppRGCTXDataType)2, 3620 },
	{ (Il2CppRGCTXDataType)2, 3056 },
	{ (Il2CppRGCTXDataType)3, 17335 },
	{ (Il2CppRGCTXDataType)2, 2291 },
	{ (Il2CppRGCTXDataType)2, 3063 },
	{ (Il2CppRGCTXDataType)3, 17370 },
	{ (Il2CppRGCTXDataType)2, 3058 },
	{ (Il2CppRGCTXDataType)3, 17347 },
	{ (Il2CppRGCTXDataType)2, 2189 },
	{ (Il2CppRGCTXDataType)3, 10279 },
	{ (Il2CppRGCTXDataType)2, 3649 },
	{ (Il2CppRGCTXDataType)2, 3065 },
	{ (Il2CppRGCTXDataType)3, 17382 },
	{ (Il2CppRGCTXDataType)2, 2314 },
	{ (Il2CppRGCTXDataType)2, 3073 },
	{ (Il2CppRGCTXDataType)3, 17524 },
	{ (Il2CppRGCTXDataType)2, 3069 },
	{ (Il2CppRGCTXDataType)3, 17447 },
	{ (Il2CppRGCTXDataType)2, 757 },
	{ (Il2CppRGCTXDataType)3, 31 },
	{ (Il2CppRGCTXDataType)3, 32 },
	{ (Il2CppRGCTXDataType)2, 1335 },
	{ (Il2CppRGCTXDataType)3, 7195 },
	{ (Il2CppRGCTXDataType)2, 758 },
	{ (Il2CppRGCTXDataType)3, 39 },
	{ (Il2CppRGCTXDataType)3, 40 },
	{ (Il2CppRGCTXDataType)2, 1345 },
	{ (Il2CppRGCTXDataType)3, 7200 },
	{ (Il2CppRGCTXDataType)3, 20421 },
	{ (Il2CppRGCTXDataType)2, 765 },
	{ (Il2CppRGCTXDataType)3, 128 },
	{ (Il2CppRGCTXDataType)2, 2720 },
	{ (Il2CppRGCTXDataType)3, 14871 },
	{ (Il2CppRGCTXDataType)2, 2721 },
	{ (Il2CppRGCTXDataType)3, 14872 },
	{ (Il2CppRGCTXDataType)3, 8047 },
	{ (Il2CppRGCTXDataType)2, 916 },
	{ (Il2CppRGCTXDataType)3, 1058 },
	{ (Il2CppRGCTXDataType)3, 1059 },
	{ (Il2CppRGCTXDataType)2, 2292 },
	{ (Il2CppRGCTXDataType)3, 10913 },
	{ (Il2CppRGCTXDataType)2, 1970 },
	{ (Il2CppRGCTXDataType)2, 1496 },
	{ (Il2CppRGCTXDataType)2, 1632 },
	{ (Il2CppRGCTXDataType)2, 1742 },
	{ (Il2CppRGCTXDataType)2, 1971 },
	{ (Il2CppRGCTXDataType)2, 1497 },
	{ (Il2CppRGCTXDataType)2, 1633 },
	{ (Il2CppRGCTXDataType)2, 1743 },
	{ (Il2CppRGCTXDataType)2, 1972 },
	{ (Il2CppRGCTXDataType)2, 1498 },
	{ (Il2CppRGCTXDataType)2, 1634 },
	{ (Il2CppRGCTXDataType)2, 1744 },
	{ (Il2CppRGCTXDataType)2, 1635 },
	{ (Il2CppRGCTXDataType)2, 1745 },
	{ (Il2CppRGCTXDataType)3, 7196 },
	{ (Il2CppRGCTXDataType)2, 1156 },
	{ (Il2CppRGCTXDataType)2, 1622 },
	{ (Il2CppRGCTXDataType)2, 1623 },
	{ (Il2CppRGCTXDataType)2, 1740 },
	{ (Il2CppRGCTXDataType)3, 7194 },
	{ (Il2CppRGCTXDataType)2, 1621 },
	{ (Il2CppRGCTXDataType)2, 1739 },
	{ (Il2CppRGCTXDataType)3, 7193 },
	{ (Il2CppRGCTXDataType)2, 1495 },
	{ (Il2CppRGCTXDataType)2, 1631 },
	{ (Il2CppRGCTXDataType)2, 1494 },
	{ (Il2CppRGCTXDataType)3, 20364 },
	{ (Il2CppRGCTXDataType)3, 6586 },
	{ (Il2CppRGCTXDataType)2, 1236 },
	{ (Il2CppRGCTXDataType)2, 1625 },
	{ (Il2CppRGCTXDataType)2, 1741 },
	{ (Il2CppRGCTXDataType)2, 1840 },
	{ (Il2CppRGCTXDataType)3, 10280 },
	{ (Il2CppRGCTXDataType)3, 10282 },
	{ (Il2CppRGCTXDataType)2, 574 },
	{ (Il2CppRGCTXDataType)3, 10281 },
	{ (Il2CppRGCTXDataType)3, 10290 },
	{ (Il2CppRGCTXDataType)2, 2192 },
	{ (Il2CppRGCTXDataType)2, 3059 },
	{ (Il2CppRGCTXDataType)3, 17348 },
	{ (Il2CppRGCTXDataType)3, 10291 },
	{ (Il2CppRGCTXDataType)2, 1679 },
	{ (Il2CppRGCTXDataType)2, 1774 },
	{ (Il2CppRGCTXDataType)3, 7207 },
	{ (Il2CppRGCTXDataType)3, 20333 },
	{ (Il2CppRGCTXDataType)2, 3070 },
	{ (Il2CppRGCTXDataType)3, 17448 },
	{ (Il2CppRGCTXDataType)3, 10283 },
	{ (Il2CppRGCTXDataType)2, 2191 },
	{ (Il2CppRGCTXDataType)2, 3057 },
	{ (Il2CppRGCTXDataType)3, 17336 },
	{ (Il2CppRGCTXDataType)3, 7206 },
	{ (Il2CppRGCTXDataType)3, 10284 },
	{ (Il2CppRGCTXDataType)3, 20332 },
	{ (Il2CppRGCTXDataType)2, 3066 },
	{ (Il2CppRGCTXDataType)3, 17383 },
	{ (Il2CppRGCTXDataType)3, 10297 },
	{ (Il2CppRGCTXDataType)2, 2193 },
	{ (Il2CppRGCTXDataType)2, 3064 },
	{ (Il2CppRGCTXDataType)3, 17371 },
	{ (Il2CppRGCTXDataType)3, 10964 },
	{ (Il2CppRGCTXDataType)3, 5471 },
	{ (Il2CppRGCTXDataType)3, 7208 },
	{ (Il2CppRGCTXDataType)3, 5470 },
	{ (Il2CppRGCTXDataType)3, 10298 },
	{ (Il2CppRGCTXDataType)3, 20334 },
	{ (Il2CppRGCTXDataType)2, 3074 },
	{ (Il2CppRGCTXDataType)3, 17525 },
	{ (Il2CppRGCTXDataType)3, 10311 },
	{ (Il2CppRGCTXDataType)2, 2195 },
	{ (Il2CppRGCTXDataType)2, 3072 },
	{ (Il2CppRGCTXDataType)3, 17450 },
	{ (Il2CppRGCTXDataType)3, 10312 },
	{ (Il2CppRGCTXDataType)2, 1682 },
	{ (Il2CppRGCTXDataType)2, 1777 },
	{ (Il2CppRGCTXDataType)3, 7212 },
	{ (Il2CppRGCTXDataType)3, 7211 },
	{ (Il2CppRGCTXDataType)2, 3061 },
	{ (Il2CppRGCTXDataType)3, 17350 },
	{ (Il2CppRGCTXDataType)3, 20339 },
	{ (Il2CppRGCTXDataType)2, 3071 },
	{ (Il2CppRGCTXDataType)3, 17449 },
	{ (Il2CppRGCTXDataType)3, 10304 },
	{ (Il2CppRGCTXDataType)2, 2194 },
	{ (Il2CppRGCTXDataType)2, 3068 },
	{ (Il2CppRGCTXDataType)3, 17385 },
	{ (Il2CppRGCTXDataType)3, 7210 },
	{ (Il2CppRGCTXDataType)3, 7209 },
	{ (Il2CppRGCTXDataType)3, 10305 },
	{ (Il2CppRGCTXDataType)2, 3060 },
	{ (Il2CppRGCTXDataType)3, 17349 },
	{ (Il2CppRGCTXDataType)3, 20338 },
	{ (Il2CppRGCTXDataType)2, 3067 },
	{ (Il2CppRGCTXDataType)3, 17384 },
	{ (Il2CppRGCTXDataType)3, 10318 },
	{ (Il2CppRGCTXDataType)2, 2196 },
	{ (Il2CppRGCTXDataType)2, 3076 },
	{ (Il2CppRGCTXDataType)3, 17527 },
	{ (Il2CppRGCTXDataType)3, 10965 },
	{ (Il2CppRGCTXDataType)3, 5473 },
	{ (Il2CppRGCTXDataType)3, 7214 },
	{ (Il2CppRGCTXDataType)3, 7213 },
	{ (Il2CppRGCTXDataType)3, 5472 },
	{ (Il2CppRGCTXDataType)3, 10319 },
	{ (Il2CppRGCTXDataType)2, 3062 },
	{ (Il2CppRGCTXDataType)3, 17351 },
	{ (Il2CppRGCTXDataType)3, 20340 },
	{ (Il2CppRGCTXDataType)2, 3075 },
	{ (Il2CppRGCTXDataType)3, 17526 },
	{ (Il2CppRGCTXDataType)3, 7204 },
	{ (Il2CppRGCTXDataType)3, 7205 },
	{ (Il2CppRGCTXDataType)3, 7215 },
	{ (Il2CppRGCTXDataType)3, 130 },
	{ (Il2CppRGCTXDataType)2, 1674 },
	{ (Il2CppRGCTXDataType)2, 1770 },
	{ (Il2CppRGCTXDataType)3, 132 },
	{ (Il2CppRGCTXDataType)2, 572 },
	{ (Il2CppRGCTXDataType)2, 766 },
	{ (Il2CppRGCTXDataType)3, 129 },
	{ (Il2CppRGCTXDataType)3, 131 },
	{ (Il2CppRGCTXDataType)2, 3660 },
	{ (Il2CppRGCTXDataType)2, 1157 },
	{ (Il2CppRGCTXDataType)2, 761 },
	{ (Il2CppRGCTXDataType)3, 82 },
	{ (Il2CppRGCTXDataType)3, 14858 },
	{ (Il2CppRGCTXDataType)2, 2722 },
	{ (Il2CppRGCTXDataType)3, 14873 },
	{ (Il2CppRGCTXDataType)2, 917 },
	{ (Il2CppRGCTXDataType)3, 1060 },
	{ (Il2CppRGCTXDataType)3, 14864 },
	{ (Il2CppRGCTXDataType)3, 5439 },
	{ (Il2CppRGCTXDataType)2, 599 },
	{ (Il2CppRGCTXDataType)3, 14859 },
	{ (Il2CppRGCTXDataType)2, 2717 },
	{ (Il2CppRGCTXDataType)3, 1474 },
	{ (Il2CppRGCTXDataType)2, 935 },
	{ (Il2CppRGCTXDataType)2, 1205 },
	{ (Il2CppRGCTXDataType)3, 5445 },
	{ (Il2CppRGCTXDataType)3, 14860 },
	{ (Il2CppRGCTXDataType)3, 5434 },
	{ (Il2CppRGCTXDataType)3, 5435 },
	{ (Il2CppRGCTXDataType)3, 5433 },
	{ (Il2CppRGCTXDataType)3, 5436 },
	{ (Il2CppRGCTXDataType)2, 1201 },
	{ (Il2CppRGCTXDataType)2, 3714 },
	{ (Il2CppRGCTXDataType)3, 7202 },
	{ (Il2CppRGCTXDataType)3, 5438 },
	{ (Il2CppRGCTXDataType)2, 1594 },
	{ (Il2CppRGCTXDataType)3, 5437 },
	{ (Il2CppRGCTXDataType)2, 1502 },
	{ (Il2CppRGCTXDataType)2, 3655 },
	{ (Il2CppRGCTXDataType)2, 1651 },
	{ (Il2CppRGCTXDataType)2, 1750 },
	{ (Il2CppRGCTXDataType)3, 6605 },
	{ (Il2CppRGCTXDataType)2, 1245 },
	{ (Il2CppRGCTXDataType)3, 7867 },
	{ (Il2CppRGCTXDataType)3, 7868 },
	{ (Il2CppRGCTXDataType)3, 7873 },
	{ (Il2CppRGCTXDataType)2, 1848 },
	{ (Il2CppRGCTXDataType)3, 7870 },
	{ (Il2CppRGCTXDataType)3, 21019 },
	{ (Il2CppRGCTXDataType)2, 1209 },
	{ (Il2CppRGCTXDataType)3, 5463 },
	{ (Il2CppRGCTXDataType)1, 1589 },
	{ (Il2CppRGCTXDataType)2, 3666 },
	{ (Il2CppRGCTXDataType)3, 7869 },
	{ (Il2CppRGCTXDataType)1, 3666 },
	{ (Il2CppRGCTXDataType)1, 1848 },
	{ (Il2CppRGCTXDataType)2, 3739 },
	{ (Il2CppRGCTXDataType)2, 3666 },
	{ (Il2CppRGCTXDataType)3, 7874 },
	{ (Il2CppRGCTXDataType)3, 7872 },
	{ (Il2CppRGCTXDataType)3, 7871 },
	{ (Il2CppRGCTXDataType)2, 441 },
	{ (Il2CppRGCTXDataType)3, 5474 },
	{ (Il2CppRGCTXDataType)2, 583 },
	{ (Il2CppRGCTXDataType)2, 1508 },
	{ (Il2CppRGCTXDataType)2, 3668 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	137,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	49,
	s_rgctxIndices,
	221,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
