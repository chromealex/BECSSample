namespace Sample {

    using BURST = Unity.Burst.BurstCompileAttribute;
    using ME.BECS;
    using ME.BECS.Transforms;

    [BURST]
    public struct SpawnEntitiesSystem : IAwake {

        public Config testConfig;
        public int count;
        
        public void OnAwake(ref SystemContext context) {

            for (int i = 0; i < this.count; ++i) {
                var ent = Ent.New(in context);
                ent.Set(new TestComponent() {
                    a = 1,
                });
                this.testConfig.Apply(in ent);
                var tr = ent.GetOrCreateAspect<TransformAspect>();
                tr.position = ent.GetRandomVector3() * 50f;
            }

        }

    }

}