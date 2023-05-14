using System;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Multimedia;
using Cadre;
using Melanchall.DryWetMidi.Common;

class Program
{
    static void Main(string[] args)
    {

        //var myTest = new test();

        //foreach (var outputDevice in OutputDevice.GetAll())
        //{
        //    Console.WriteLine(outputDevice.Name);
        //}

        //using (var outputDevice = OutputDevice.GetByName("Microsoft GS Wavetable Synth"))
        //{
        //    outputDevice.EventSent += OnEventSent;

        //    var noteOnEvent = new NoteOnEvent
        //    {
        //        Channel = (FourBitNumber)0,
        //        NoteNumber = (SevenBitNumber)60,
        //        Velocity = (SevenBitNumber)100
        //    };

        //    var noteOffEvent = new NoteOffEvent
        //    {
        //        Channel = (FourBitNumber)0,
        //        NoteNumber = (SevenBitNumber)60,
        //        Velocity = (SevenBitNumber)100
        //    };

        //    outputDevice.SendEvent(noteOnEvent);
        //    outputDevice.SendEvent(noteOffEvent);
        //}

        //void OnEventSent(object sender, MidiEventSentEventArgs e)
        //{
        //    var midiDevice = (MidiDevice)sender;
        //    Console.WriteLine($"Event sent to '{midiDevice.Name}' at {DateTime.Now}: {e.Event}");
        //}

        var midiFile = new MidiFile(
    new TrackChunk(
        new SetTempoEvent(500000)),
    new TrackChunk(
        new TextEvent("It's just single note track..."),
        new NoteOnEvent((SevenBitNumber)60, (SevenBitNumber)45),
        new NoteOffEvent((SevenBitNumber)60, (SevenBitNumber)0)
        {
            DeltaTime = 400
        }));

        midiFile.Write("My Future Great Song.mid");

    }
}