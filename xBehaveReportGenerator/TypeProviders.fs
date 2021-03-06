module xBehaveReportGenerator.TypeProviders

open FSharp.Data

type Data = XmlProvider<"""<?xml version="1.0" encoding="utf-8"?>
<TestRun id="3e4a7e5a-6ff0-4159-8501-01bc2d193c9d" name="blah 2019-12-29 12:09:42" runUser="blah" xmlns="http://microsoft.com/schemas/VisualStudio/TeamTest/2010">
  <Times creation="2019-12-29T12:09:42.9702545+01:00" queuing="2019-12-29T12:09:42.9702568+01:00" start="2019-12-29T12:09:42.0174229+01:00" finish="2019-12-29T12:09:43.0083045+01:00" />
  <TestSettings name="default" id="bf6b8627-311b-4b87-8de4-3dcbab75da18">
    <Deployment runDeploymentRoot="ABADDON_2019-12-29_12_09_42" />
  </TestSettings>
  <Results>
    <UnitTestResult executionId="7ab1bf5c-15e7-4018-9765-3cebb7b2dc48" testId="e66a06bd-c031-5863-c7e2-e46519d621ef" testName="Sample.SimpleSample.SimpleScenario() [02] a value exists" computerName="ABADDON" duration="00:00:00.0000449" startTime="2019-12-29T12:09:42.9047288+01:00" endTime="2019-12-29T12:09:42.9047292+01:00" testType="13cdc9d9-ddb5-4fa4-a97d-d965ccfc6d4b" outcome="Passed" testListId="8c84fa94-04c1-424b-9868-57a2d4851a1d" relativeResultsDirectory="7ab1bf5c-15e7-4018-9765-3cebb7b2dc48" />
    <UnitTestResult executionId="b158695a-cdbd-440b-9659-29e88a93c178" testId="f65bd867-1d3d-3777-7915-5ab0cd873988" testName="Sample.ExampleSample.WithExample(s: &quot;foo&quot;, i: 42) [02] when the example value is changed" computerName="ABADDON" duration="00:00:00.0000621" startTime="2019-12-29T12:09:42.9048701+01:00" endTime="2019-12-29T12:09:42.9048702+01:00" testType="13cdc9d9-ddb5-4fa4-a97d-d965ccfc6d4b" outcome="Passed" testListId="8c84fa94-04c1-424b-9868-57a2d4851a1d" relativeResultsDirectory="b158695a-cdbd-440b-9659-29e88a93c178" />
  </Results>
  <TestDefinitions>
    <UnitTest name="Sample.SimpleSample.SimpleScenario" storage="c:\projects\xbehavereportgenerator\sample\bin\debug\netcoreapp3.0\sample.dll" id="e66a06bd-c031-5863-c7e2-e46519d621ef">
      <Execution id="0d20729e-f05b-4989-9aa9-d37a661cda6f" />
      <TestMethod codeBase="C:\Projects\xBehaveReportGenerator\Sample\bin\Debug\netcoreapp3.0\Sample.dll" adapterTypeName="executor://xunit/VsTestRunner2/netcoreapp" className="Sample.SimpleSample" name="Sample.SimpleSample.SimpleScenario" />
    </UnitTest>
    <UnitTest name="Sample.SimpleSample.AnotherSimpleScenario" storage="c:\projects\xbehavereportgenerator\sample\bin\debug\netcoreapp3.0\sample.dll" id="160f8564-7f15-9f4a-8a1d-e77f351f752f">
      <Execution id="fce14c4b-7f41-42c0-81ba-7dac008df6d5" />
      <TestMethod codeBase="C:\Projects\xBehaveReportGenerator\Sample\bin\Debug\netcoreapp3.0\Sample.dll" adapterTypeName="executor://xunit/VsTestRunner2/netcoreapp" className="Sample.SimpleSample" name="Sample.SimpleSample.AnotherSimpleScenario" />
    </UnitTest>
  </TestDefinitions>
  <TestEntries>
    <TestEntry testId="e66a06bd-c031-5863-c7e2-e46519d621ef" executionId="7ab1bf5c-15e7-4018-9765-3cebb7b2dc48" testListId="8c84fa94-04c1-424b-9868-57a2d4851a1d" />
    <TestEntry testId="f65bd867-1d3d-3777-7915-5ab0cd873988" executionId="b158695a-cdbd-440b-9659-29e88a93c178" testListId="8c84fa94-04c1-424b-9868-57a2d4851a1d" />
  </TestEntries>
  <TestLists>
    <TestList name="Results Not in a List" id="8c84fa94-04c1-424b-9868-57a2d4851a1d" />
    <TestList name="All Loaded Results" id="19431567-8539-422a-85d7-44ee4e166bda" />
  </TestLists>
  <ResultSummary outcome="Completed">
    <Counters total="21" executed="21" passed="21" failed="0" error="0" timeout="0" aborted="0" inconclusive="0" passedButRunAborted="0" notRunnable="0" notExecuted="0" disconnected="0" warning="0" completed="0" inProgress="0" pending="0" />
    <Output>
      <StdOut>[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.1 (64-bit .NET Core 3.0.0)&#xD;
[xUnit.net 00:00:00.30]   Discovering: Sample&#xD;
[xUnit.net 00:00:00.33]   Discovered:  Sample&#xD;
[xUnit.net 00:00:00.33]   Starting:    Sample&#xD;
[xUnit.net 00:00:00.44]   Finished:    Sample&#xD;
</StdOut>
    </Output>
  </ResultSummary>
</TestRun>""">


