namespace SongConverter.Models;

public record SongInfo(string Title, string Subtitle);

public record SongDetail(string Title, string Subtitle, string? FullTitle, string? FolderTitle, string? Wave = null);

/// <summary>
/// アーケード公式リストに一致しなかった（＝ESE限定の未収録）曲を、
/// 破棄せず別枠としてカテゴリ単位でソート・出力するための一時保持情報。
/// 並列走査フェーズで収集し、走査完了後にカテゴリごとへ採番・コピーする。
/// </summary>
public sealed record EsePreservedSong(
    string EseCategory, // AC側カテゴリ名（「02 アニメ」等の表示名）
    string SongDir,     // コピー元の曲フォルダ
    string TjaPath,     // 代表となるTJAファイル
    string? Wave,       // 対応する音声ファイル名（WAVE指定）
    string Title,       // 表示タイトル
    string Subtitle,    // 表示サブタイトル
    string SortKey,     // カテゴリ内ソート用キー（正規化タイトル）
    string Reason);     // 未収録となった理由（レポート用）
