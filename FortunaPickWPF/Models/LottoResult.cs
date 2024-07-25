﻿namespace FortunaPickWPF.Models;

public class LottoResult(DateOnly date, int ball1, int ball2, int ball3, int ball4, int ball5, int ball6, int bonusball)
{
    public DateOnly? Date { get; } = date;
    public int? Ball1 { get; } = ball1;
    public int? Ball2 { get; } = ball2;
    public int? Ball3 { get; } = ball3;
    public int? Ball4 { get; } = ball4;
    public int? Ball5 { get; } = ball5;
    public int? Ball6 { get; } = ball6;
    public int? BonusBall { get; } = bonusball;

}
