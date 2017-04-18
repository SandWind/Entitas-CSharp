//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public ClassWithEntitIndexAttributeComponent classWithEntitIndexAttribute { get { return (ClassWithEntitIndexAttributeComponent)GetComponent(TestComponentsLookup.ClassWithEntitIndexAttribute); } }
    public bool hasClassWithEntitIndexAttribute { get { return HasComponent(TestComponentsLookup.ClassWithEntitIndexAttribute); } }

    public void AddClassWithEntitIndexAttribute(ClassWithEntitIndexAttribute newValue) {
        var index = TestComponentsLookup.ClassWithEntitIndexAttribute;
        var component = CreateComponent<ClassWithEntitIndexAttributeComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceClassWithEntitIndexAttribute(ClassWithEntitIndexAttribute newValue) {
        var index = TestComponentsLookup.ClassWithEntitIndexAttribute;
        var component = CreateComponent<ClassWithEntitIndexAttributeComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveClassWithEntitIndexAttribute() {
        RemoveComponent(TestComponentsLookup.ClassWithEntitIndexAttribute);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherClassWithEntitIndexAttribute;

    public static Entitas.IMatcher<TestEntity> ClassWithEntitIndexAttribute {
        get {
            if(_matcherClassWithEntitIndexAttribute == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.ClassWithEntitIndexAttribute);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherClassWithEntitIndexAttribute = matcher;
            }

            return _matcherClassWithEntitIndexAttribute;
        }
    }
}