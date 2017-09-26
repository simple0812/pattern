class Sound {
  
  constructor(context) {
    this.context = context;
  }
  
  init() {
    this.oscillator = this.context.createOscillator();
    this.gainNode = this.context.createGain();

    this.oscillator.connect(this.gainNode);
    this.gainNode.connect(this.context.destination);
  }

  play(value) {
    this.init();

    this.gainNode.gain.setValueAtTime(0.5, this.context.currentTime);
            
    this.oscillator.start();
  }
  
  stop() {
    this.gainNode.gain.exponentialRampToValueAtTime(0.001, this.context.currentTime + 1);
    this.oscillator.stop(this.context.currentTime + 1);
  }
 
}  