namespace Sample {

    using BURST = Unity.Burst.BurstCompileAttribute;
    using ME.BECS;
    using ME.BECS.Jobs;
    using ME.BECS.Transforms;
    using Unity.Mathematics;

    [BURST]
    public struct FilterEntitiesSystem : IUpdate {

        [BURST]
        public struct JobSetTest : IJobForComponents<TestComponent> {
            
            public void Execute(in JobInfo jobInfo, in Ent ent, ref TestComponent c0) {

                c0.a = 2;

            }

        }

        [BURST]
        public struct JobMove : IJobForAspects<TransformAspect> {

            public float dt;
            
            public void Execute(in JobInfo jobInfo, in Ent ent, ref TransformAspect tr) {

                tr.position += new float3(1f, 0f, 0f) * this.dt;

            }

        }

        public void OnUpdate(ref SystemContext context) {

            var dependsOnSet = context.Query().AsParallel().Schedule<JobSetTest, TestComponent>();
            var dependsOnMove = context.Query().AsParallel().Schedule<JobMove, TransformAspect>(new JobMove() {
                dt = context.deltaTime,
            });
            context.SetDependency(Unity.Jobs.JobHandle.CombineDependencies(dependsOnSet, dependsOnMove));

        }

    }

}