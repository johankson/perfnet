namespace Examples;

public class LargeDuck : Duck
{
    public byte[] Payload = new byte[1024 * 1024]; // 1 MB Duck Payload
}