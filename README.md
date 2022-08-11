# NStafo

> Get the total number of stars and forks on a particular github repository.

Borrowed the name from https://github.com/CodeDotJS/stafo

## Usage

- `stars` :

```c#
var nstafo = new NStafo.NStafo();

Console.WriteLine(await nstafo.NumStarsAsync("github/docs"));
```

- `forks` :

```js
var nstafo = new NStafo.NStafo();

Console.WriteLine(await nstafo.NumForksAsync("github/docs"));
```

## API

### __```NStafo::NumStarsAsync('username/repository')```__

- Returns an integer with ```total stars``` for the specified repository.


### __```NStafo::NumForksAsync('username/repository')```__

- Returns an integer with ```total forks``` for the specified repository.


__```username/repository```__


# License

MIT &copy; [Matthew Groves](https://crosscuttingconcerns.com/)